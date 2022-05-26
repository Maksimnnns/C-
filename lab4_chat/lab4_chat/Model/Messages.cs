using Supabase;
using Postgrest.Attributes;

namespace AvaloniaDatabase.Model
{
    public class Messages : SupabaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("message")]
        public string Message { get; set; } = string.Empty;

        [Column("user")]
        public string User { get; set; } = string.Empty;

    }
}