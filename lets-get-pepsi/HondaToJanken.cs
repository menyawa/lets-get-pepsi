using System;

namespace lets_get_pepsi
{
    class HondaToJanken
    {
        public static void Main(string[] args) {
            Console.WriteLine("出す手を数字で入力してください");
            Console.WriteLine("1:グー  2:チョキ  3:パー");
            string inputNumber = Console.ReadLine();

            string playerHands = "";
            string hondaHands = "";
            bool youWin = false;
            if (inputNumber == "1") {
                playerHands = "グー";
                hondaHands = "パー";
            } else if (inputNumber == "2") {
                playerHands = "チョキ";
                hondaHands = "グー";
            } else if (inputNumber == "3") {
                playerHands = "パー";
                hondaHands = "チョキ";
            } else {
                youWin = true;
            }
            Console.WriteLine();

            if (youWin) {
                Console.WriteLine("やるやん！");
                Console.WriteLine("明日は俺にリベンジさせて。");
                Console.WriteLine("では、どうぞ\n");

                Console.WriteLine("JAPAN");
                Console.WriteLine("COLA");
                Console.WriteLine("pepsi");
            } else {
                Console.WriteLine("あなたが出した手：" + playerHands + "　本田圭佑が出した手：" + hondaHands + "\n");
                Console.WriteLine("YOU LOSE");
                Console.WriteLine("俺の勝ち！");
                Console.WriteLine("なんで負けたか、明日まで考えといてください。");
                Console.WriteLine("そしたら何かが見えてくるはずです。");
                Console.WriteLine("ほな、いただきます。\n");

                Console.WriteLine("JAPAN");
                Console.WriteLine("COLA");
                Console.WriteLine("pepsi\n");

                Console.WriteLine("一日一回勝負。");
                Console.WriteLine("じゃあ、また明日。");
            }

        }
    }
}
