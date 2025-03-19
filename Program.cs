// See https://aka.ms/new-console-template for more information
/*
 * Documentation
 * Entrée: (int) nombre de minutes
 * Sortie : (tuple) le temps en heure et en minute
 * Retourne le temps en un format agréable
 *  */


//(Desoler on avait pas vu que fallait pas le faire, on va simuler qu'on l'a pas fait
//int nb_min = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez un nb de minutes");
int nb_min =  int.Parse(Console.ReadLine());
int[] time = {0,0};
time[0] = nb_min / 60;
time[1] = nb_min % 60;
Console.WriteLine(time[0].ToString()+":"+time[1].ToString() );
