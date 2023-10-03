using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace takenbeheer_models
{
    [Table("Comments")]
    public partial class Comment
    {
        private string _commentID;
        private string _toDoTaskID;
        private string _content;
        private string _reason;
        private DateTime _commentCreationDate;

        public DateTime CommentCreationDate
        {
            get { return _commentCreationDate; }
            set { _commentCreationDate = value; }
        }

        [Required]
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        [Required]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public string ToDoTaskID
        {
            get { return _toDoTaskID; }
            set { _toDoTaskID = value; }
        }

        [Key]
        public string CommentID
        {
            get { return _commentID; }
            set { _commentID = value; }
        }

        // Navigation properties
        [ForeignKey("ToDoTaskID")]
        public ToDoTaak ToDoTaak { get; set; }
        
    }
}