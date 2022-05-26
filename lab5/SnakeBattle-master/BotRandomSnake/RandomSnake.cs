using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BotRandomSnake
{

    public class RandomSnake : ISmartSnake
    {
        public Move Direction { get; set; }
        public bool Reverse { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Point Closest { get; set; }
        public List<Point> Stones { get; set; }

        private DateTime dt = DateTime.Now;
        private static Random rnd = new Random();

        // Parameters for A* algorithm
        public List<Node> OpenSet { get; set; } = new List<Node>();
        public List<Node> ClosedSet { get; set; } = new List<Node>();
        public List<Point> Path { get; set; } = new List<Point>();


        public class Node
        {
            public double F { get; set; }
            public double G { get; set; }
            public double H { get; set; }
            public Point CurPoint { get; set; }
            public List<Node> Neighbours { get; set; }
            public Node CameFrom { get; set; } // ?

            public Node(Point point = new Point())
            {
                this.F = 0;
                this.G = 0;
                this.H = 0;
                this.CurPoint = point;
                this.Neighbours = new List<Node>();
                this.CameFrom = null;
            }

            public void AddNeighbours(Point current)
            {
                this.Neighbours.Add(new Node(new Point(current.X, current.Y - 1)));  // up
                this.Neighbours.Add(new Node(new Point(current.X + 1, current.Y)));  // right
                this.Neighbours.Add(new Node(new Point(current.X, current.Y + 1)));  // down
                this.Neighbours.Add(new Node(new Point(current.X - 1, current.Y)));  // left
            }
        }

        public void Startup(Size size, List<Point> stones)
        {
            string test = new Point(size.Width, size.Height).ToString();
            Name = test;
            Color = Color.Blue;
            Stones = stones;
            OpenSet = new List<Node>();
            ClosedSet = new List<Node>();
            Path = new List<Point>();
        }

        public double HeuristicD(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public bool IsEmptyNode(Node node)
        {
            return node is null;
        }

        public bool Include(List<Node> arr, Point point)
        {
            foreach (Node node in arr)
            {
                if (node.CurPoint == point)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveFromList(Node cur, List<Node> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == cur)
                {
                    arr.RemoveAt(i);
                }
            }
        }

        public Point ClosestPoint(Point snake, List<Point> food)
        {
            Point closest = new Point();
            double minDist = int.MaxValue;
            foreach (Point f in food)
            {
                var dist = HeuristicD(snake, f);
                if (dist < minDist)
                {
                    closest.X = f.X;
                    closest.Y = f.Y;
                    minDist = dist;
                }
            }
            return closest;
        }

        public List<Point> AStarAlgoritm(Point start, Point end, List<Point> snakeTail)
        {
            for (int i = 0; i < snakeTail.Count; i++)
            {
                Stones.Add(snakeTail[i]);
            }
            OpenSet.Clear();
            ClosedSet.Clear();
            Node startA = new Node(start);
            Node endB = new Node(end);
            OpenSet.Add(startA);

            while (true)
            {
                if (OpenSet.Count > 0)
                {
                    var best = 0;  // index of the best cell to go

                    for (int i = 0; i < OpenSet.Count; i++)
                    {
                        if (OpenSet[i].F < OpenSet[best].F)
                            best = i;
                    }

                    var current = OpenSet[best];

                    if (current.CurPoint == endB.CurPoint)
                    {
                        break;
                    }

                    RemoveFromList(current, OpenSet);
                    ClosedSet.Add(current);

                    current.AddNeighbours(current.CurPoint);

                    for (int i = 0; i < current.Neighbours.Count; i++)
                    {
                        var n = current.Neighbours[i];

                        if (!Include(ClosedSet, n.CurPoint) && !Stones.Contains(n.CurPoint))
                        {
                            var tentG = current.G + 1;
                            if (Include(OpenSet, n.CurPoint))
                            {
                                if (tentG < n.G)
                                    n.G = tentG;
                            }
                            else
                            {
                                n.G = tentG;
                                OpenSet.Add(n);
                            }
                            n.H = HeuristicD(n.CurPoint, end);
                            n.F = n.G + n.H;
                            n.CameFrom = current;
                        }
                    }
                    Path = new List<Point>();
                    var t = current;
                    while (!IsEmptyNode(t))
                    {
                        Path.Add(t.CurPoint);
                        t = t.CameFrom;
                    }
                }
            }
            Path.Insert(0, end);
            return Path;
        }


        public bool FoodHasBeenEaten { get; set; } = true;
        public List<Point> PathToFood { get; set; }

        public void Update(Snake snake, List<Snake> enemies, List<Point> food, List<Point> dead)
        {
            if (FoodHasBeenEaten)
            {
                Closest = ClosestPoint(snake.Position, food);
                PathToFood = AStarAlgoritm(snake.Position, Closest, snake.Tail);
                PathToFood.Reverse();
                FoodHasBeenEaten = false;
            }

            Point snakePos = snake.Position;
            if (snakePos.X == PathToFood[0].X && snakePos.Y == PathToFood[0].Y + 1)
            {
                Direction = Move.Up;
            }
            else if (snakePos.X == PathToFood[0].X - 1 && snakePos.Y == PathToFood[0].Y)
            {
                Direction = Move.Right;
            }
            else if (snakePos.X == PathToFood[0].X && snakePos.Y == PathToFood[0].Y - 1)
            {
                Direction = Move.Down;
            }
            else if (snakePos.X == PathToFood[0].X + 1 && snakePos.Y == PathToFood[0].Y)
            {
                Direction = Move.Left;
            }
            else
            {
                Direction = Move.Nothing;
            }

            PathToFood.RemoveAt(0);

            if (PathToFood.Count <= 0)
            {
                FoodHasBeenEaten = true;
            }
        }
    }
}