class program{
    static void Main(string[] args){
        Console.Write("new password :");
        int w = int.Parse(Console.ReadLine());

        Console.Write("agency :");
        string a = (Console.ReadLine());

        if(w <= 999999 && w >= 0){
            int r = w / 100000 % 10;
            int y = w / 10000 % 10;
            int i = w / 1000 % 10;
            int n = w / 100 % 10;
            int b = w / 10 % 10;
            int o = w % 10;
        
        if(a == "CIA") {
            if(i >= 6 && i != 8 && b != 1 && b != 3 && b != 5 && o % 3 == 0 ){
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }

        if(a == "FBI") {
            if(r >= 4 && r <= 7 && n % 2 == 0 && n != 6 && y % 2 != 0 ){
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }

        
        if(a == "NSA") {
            if(30 % o == 0 && n % 3 == 0 || n % 2 == 1 && r == 7 || y == 7 || i == 7 || n == 7 || b == 7 || o == 7 ){
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }

       
        } else {
            Console.WriteLine("False");
    } 
}
}
