namespace PaizaTest
{
    public class Car
    {
        // メンバ変数
        // アクセス修飾子がprivateのため、このclass内からしか参照できない(このclass内からしか変更されないことを保証できる)
        // privateの場合は省略可能
        string _maker = string.Empty;
        private string _model = string.Empty;
        private double _fuel = -1;
        private double _consumption = -1;

        // コンストラクタ
        // 自身を"インスタンス化(newステートメントを使用)"した際に自動で一度だけ呼ばれるメソッド
        // コンストラクタもメソッドのため、引数がある場合インスタンス化時に指定しないとエラー
        public Car(string maker, string model, double fuel, double consumption)
        {
            _maker = maker;
            _model = model;
            _fuel = fuel;
            _consumption = consumption;
        }
        
        // 以下メソッド
        // 自身のメンバ変数を参照して返す（メンバ変数はprivateだが同じclass内なので参照できる）
        
        public string Maker()
        {
            // 自身を指す "this" は省略可能
            return this._maker;
        }

        public string Model()
        {
            return _model;
        }

        public double Fuel()
        {
            return _fuel;
        }

        public double Consumption()
        {
            return _consumption;
        }
    }
}