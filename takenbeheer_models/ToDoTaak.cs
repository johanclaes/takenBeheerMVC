using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takenbeheer_models
{
    public partial class ToDoTaak
    {
        private string _toDoTaskID;
        private string _title;
        private string _description;
        private string _status;
        private DateTime _toDoCreationDate;
        private DateTime _toDoStartDate;
        private DateTime _toDoFinshedDate;

        //public DateTime ToDoFinishedDate
        //{
        //    get { return _toDoFinshedDate; }
        //    set { _toDoFinshedDate = value; }
        //}

        public DateTime? ToDoFinishedDate
        {
            get; set;
        }

        //public DateTime? ToDoStartDate
        //{
        //    get { return _toDoStartDate; }
        //    set { _toDoStartDate = value; }
        //}

        public DateTime? ToDoStartDate
        {
            get; set;
        }

        [Required]
        public DateTime ToDoCreationDate
        {
            get { return _toDoCreationDate; }
            set { _toDoCreationDate = value; }
        }

        [Required]
        public string Status
        {
            get; set; 
        }

        [MaxLength(120)]
        public string? Description
        {
            get; set;
        }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Key]
        public string ToDoTaskID
        {
            get { return _toDoTaskID; }
            set { _toDoTaskID = value; }
        }

        // Navigation properties
        public ICollection<Comment> Comments { get; set; }

    }
}
