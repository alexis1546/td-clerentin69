// See https://aka.ms/new-console-template for more information
/*
 * Documentation
 * Entrée: (int) nombre de minutes
 * Sortie : (tuple) le temps en heure et en minute
 * Retourne le temps en un format agréable
 *  */

static(int,int)  temps(int nb_min) {
    (int,int) time = (0,0);
    time.Item1 = nb_min / 60;
    time.Item2 = nb_min % 60;
    return time;
}

//(Desoler on avait pas vu que fallait pas le faire, on va simuler qu'on l'a pas fait
//int nb_min = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez un nb de minutes");
int nb_min =  int.Parse(Console.ReadLine());
(int,int) res = temps(nb_min);
Console.WriteLine(res.Item1.ToString()+":"+res.Item2.ToString() );
