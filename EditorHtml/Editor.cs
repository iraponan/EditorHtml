using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EditorHtml {
    internal static class Editor {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(" MODO EDITOR");
            Console.WriteLine(" -----------");
            Start();
        }

        public static void Start() {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(" ------------------------");
            Console.Write("_Deseja salvar o arquivo? \n" +
                "   1 - SIM \n" +
                "   2 - NÃO \n" +
                " Opção: ");

            var save = short.Parse(Console.ReadLine());

            switch (save) {
                case 1: FileSave(file.ToString());
                    break;
                default: Menu.Show();
                    break;
            }
        }

        private static void FileSave(string texto) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Qual caminho para salvar o arquivo?");

            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho)) {
                arquivo.Write(texto);
            }

            Console.WriteLine(" Arquivo " + caminho + " salvo com sucesso!");
            Thread.Sleep(5000);
            Menu.Show();
        }
    }
}
