using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace takenbeheer_models
{
    public partial class Comment
    {
        // constructor
        public Comment(string content, string reason) {
            Guid guid = Guid.NewGuid();
            this.CommentID = guid.ToString();                       
            this.Content = content;
            this.Reason = reason;
            this.CommentCreationDate = DateTime.Now;


        }

        // methods
        public override string ToString()
        {
            return "abc";
        }



    }

}