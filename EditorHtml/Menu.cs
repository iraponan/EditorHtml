using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml {
    internal static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(10, 30);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen(int altura, int largura) {
            ScreenLine(largura);
            ScreenSize(altura, largura);
            ScreenLine(largura);
        }

        private static void ScreenLine(int largura) {
            Console.Write("+");
            for (int i = 0; i <= largura; i++) {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        private static void ScreenSize(int altura, int largura) {
            for (int lines = 0; lines <= altura; lines++) {
                Console.Write("|");
                for (int i = 0; i <= largura; i++) {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions() {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo!");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option) {
            switch(option) {
                case 1: Editor.Show(); 
                    break;
                case 2: Viewer.Show(OpenFile());
                    break;
                case 0: {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show();
                    break;
            }
        }

        private static string OpenFile() {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");

            string dir = Console.ReadLine();

            using (var file = new StreamReader(dir)) {
                string text = file.ReadToEnd();
                return text;
            }
        }
    }
}
