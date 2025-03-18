// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrez un nb de minutes");
int nb_min =  int.Parse(Console.ReadLine());
int[] time = {0,0};
time[0] = nb_min / 60;
time[1] = nb_min % 60;
Console.WriteLine(time[0].ToString()+":"+time[1].ToString() );