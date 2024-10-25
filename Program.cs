// See https://aka.ms/new-console-template for more information


/*static void Array1()
{
    int[] a = new int[5];
        for(int c=0; c < a.GetLength(0); c++){
            Console.WriteLine("tal nummer" + (c+1) +" :");
             a[c]  = int.Parse(Console.ReadLine());
        }
    Console.WriteLine((a[4],a[3],a[2],a[1],a[0]));
}
*/
/*static void Array2(String[] args)
{
    double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6,2.9};
     for()
}*/


static void tictactoe(string[] args)
{
    char[,] gamebord = new char[,]{{'-','-','_'},
                                   {'-','-','-'},
                                   {'-','-','-'} };

    gamebord[0,1] ='x';
    gamebord[1,1] ='o';
    gamebord[0,2] ='x';       


