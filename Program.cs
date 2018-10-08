using System;

namespace lghtClasses
{
    class Program {
        static void Main (string[] args) {

            Library PersonalLib = new Library() {
                Name = "Alejandro's Library",
                Address = "My House"
            };

            Book MagicMountain = new Book(){
                Title = "Magic Mountian",
                Author = "Thomas Mann",
                ISBN = "ABC123"
            };
            Book Neuromancer = new Book(){
                Title = "Neuromancer",
                Author = "Willian Gibson",
                ISBN = "DEF321"
            };
            Book Kokoro = new Book(){
                Title = "Kokoro",
                Author = "Natsume Soseki",
                ISBN = "TER897"
            };
            Book TheClown = new Book() {
                Title = "The Clown",
                Author = "Heinrich Boll",
                ISBN = "CBC444"

            };

            PersonalLib.AddBook(MagicMountain);
            PersonalLib.AddBook(Neuromancer);
            PersonalLib.AddBook(Kokoro);
            PersonalLib.AddBook(TheClown);





        }
    }
}