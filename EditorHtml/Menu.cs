using System;
using System.Collections.Generic;
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
        }

        public static void DrawScreen(int altura, int largura) {
            TelaLimite(largura);
            TelaTamanho(altura, largura);
            TelaLimite(largura);
        }

        private static void TelaLimite(int largura) {
            Console.Write("+");
            for (int i = 0; i <= largura; i++) {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        private static void TelaTamanho(int altura, int largura) {
            for (int lines = 0; lines <= altura; lines++) {
                Console.Write("|");
                for (int i = 0; i <= largura; i++) {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}
