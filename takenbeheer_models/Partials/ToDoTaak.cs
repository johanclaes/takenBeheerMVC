using Microsoft.Identity.Client;
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
        // constructor

        public ToDoTaak(string title, string description)
        {
            Guid guid = Guid.NewGuid();
            this.ToDoTaskID = guid.ToString();
            this.Title = title;
            this.Description = description;
            this.Status = "Open";
            this.ToDoCreationDate = DateTime.Now;
            // this.ToDoStartDate = nullable;
        }

        // methods
        public override string ToString()
        {
            return "abc";
        }

        public string created() 
        {  
            return "abc";                           // de bedoeling is dat hier de created wordt berekend, dus huidige datum - created datum => to string
        }



    }



}
