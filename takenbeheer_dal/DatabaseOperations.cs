using Microsoft.Identity.Client;
using System.Numerics;
using takenbeheer_models;

namespace takenbeheer_dal

{
    public class DatabaseOperations
    {

        public static List<ToDoTaak> HaalTakenOp()
        {
            using TakenContext ctx = new TakenContext();
            return ctx.ToDoTaken.ToList();
        }


        public static List<Comment> HaalCommentsOp(String toDoTaak)
        {
            using TakenContext ctx = new TakenContext();                    // hier zit nog een fout... enkel comment waar FK = PK van taak.
            return ctx.Comments.ToList();
        }

        public static int VoegToDoTaakToe(ToDoTaak toDoTaak)             // toevoegen aan de dB van extra taak
        {
            using TakenContext ctx = new TakenContext();
            ctx.Add(toDoTaak);
            ctx.SaveChanges();
            return 1;
        }

        public static int UpdateToDoTaakToe(ToDoTaak toDoTaak)             // updaten van 1 record in dB
        {
            using TakenContext ctx = new TakenContext();
            ctx.Update(toDoTaak);
            ctx.SaveChanges();
            return 1;
        }

        public static int VewijderToDoTaakToe(ToDoTaak toDoTaak)             // verwijder van 1 record in dB
        {
            using TakenContext ctx = new TakenContext();
            ctx.Remove(toDoTaak);
            ctx.SaveChanges();
            return 1;
        }

        public static int VoegCommentToe(Comment comment)             // toevoegen aan de dB van extra comment
        {
            using TakenContext ctx = new TakenContext();
            ctx.Add(comment);
            ctx.SaveChanges();
            return 1;
        }

    }
}