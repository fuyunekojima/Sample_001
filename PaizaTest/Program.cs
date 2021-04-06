using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car型の変数を宣言してCar型をインスタンス化（Car型という設計図から実態(インスタンス)を作り出すイメージ）
            // Car型はコンストラクタで引数指定があるので必須
            Car prius = new Car("トヨタ", "プリウス", 40, 30.5);
            
            // 出力
            Console.WriteLine("出力結果:");
            Console.WriteLine($"メーカー: {prius.Maker()}, 車種: {prius.Model()}, 燃料: {prius.Fuel()}, 燃費: {prius.Consumption()}");
            
            // これはコンパイルが通らない
            // priusインスタンスの外(ここはProgramクラス)からprivateな変数を参照しているため
            Console.WriteLine(prius._maker);
            
            // prius._makerを参照したい場合は、publicかつ_makerを返すprius.Maker()メソッドをよびだす
            Console.WriteLine(prius.Maker());
        }

        // privateは省略できる
        void SampleMethod()
        {
            // staticについて
            // staticなメソッドはインスタンスからでなくとも呼び出せる(newしなくてもいい。プログラムの初期化時にメモリに乗り、最後まで消えない)
            var result1 = Program.SampleStaticMethod();
            
            // staticじゃない場合はインスタンスからじゃないと呼べない
            // ↓エラー
            var result2 = Program.SampleInstanceMethod();
            
            // ↓動く
            var program = new Program();
            var result3 = program.SampleInstanceMethod();
        }


        string SampleInstanceMethod()
        {
            return "staticじゃないよ";
        }
        
        static string SampleStaticMethod()
        {
            return "staticだよ";
        }
        
    }
}