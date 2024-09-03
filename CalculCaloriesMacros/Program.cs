// a. Calcul du Métabolisme Basal (BMR) :
// 
// Le métabolisme basal (BMR) représente la quantité de calories que votre corps brûle au repos, juste pour maintenir les fonctions vitales (respiration, circulation sanguine, etc.). Voici une formule courante pour estimer le BMR : la formule de Harris-Benedict.
// 
//     Pour les hommes :
//     BMR=88,36+(13,4×poids en kg)+(4,8×taille en cm)−(5,7×aˆge en anneˊes)BMR=88,36+(13,4×poids en kg)+(4,8×taille en cm)−(5,7×aˆge en anneˊes)
// 
//     Pour les femmes :
//     BMR=447,6+(9,2×poids en kg)+(3,1×taille en cm)−(4,3×aˆge en anneˊes)BMR=447,6+(9,2×poids en kg)+(3,1×taille en cm)−(4,3×aˆge en anneˊes)



// Je déclare les variables et les initialise pour les calculs : 

int poids = 0;
int taille = 0;
int age = 0;
int sexe = 0;

// Je demande à l'utilisateur de rentrer son poids, sa taille, son âge et son sexe :

Console.WriteLine("Entrez votre poids en kg : ");
poids = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrez votre taille en cm : ");
taille = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrez votre âge : ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrez votre sexe (1 pour homme, 2 pour femme) : ");
sexe = Convert.ToInt32(Console.ReadLine());

// Je déclare la variable BMR pour le calcul du Métabolisme Basal :

double BMR = 0;

// Je fais le calcul du Métabolisme Basal en fonction du sexe :

if (sexe == 1)
{
    BMR = 88.36 + (13.4 * poids) + (4.8 * taille) - (5.7 * age);
}
else if (sexe == 2)
{
    BMR = 447.6 + (9.2 * poids) + (3.1 * taille) - (4.3 * age);
}

// J'affiche le résultat du calcul du Métabolisme Basal :

Console.WriteLine("Votre Métabolisme Basal est de : " + BMR + " calories");

// b. Calcul des besoins caloriques journaliers :

// Pour calculer les besoins caloriques journaliers, il faut multiplier le Métabolisme Basal par un coefficient en fonction de l'activité physique de la personne. Voici les coefficients couramment utilisés :
//
//     Sédentaire (peu ou pas d'exercice) : BMR x 1,2
//     Légèrement actif (exercice léger/sport 1-3 jours/semaine) : BMR x 1,375
//     Modérément actif (exercice modéré/sport 3-5 jours/semaine) : BMR x 1,55
//     Très actif (exercice intense/sport 6-7 jours/semaine) : BMR x 1,725
//     Extrêmement actif (exercice très intense/activité physique quotidienne et travail physique) : BMR x 1,9

// Je déclare la variable activite pour le coefficient d'activité physique :

double activite = 0;

// Je demande à l'utilisateur de rentrer son niveau d'activité physique :

Console.WriteLine("Entrez votre niveau d'activité physique (1 pour sédentaire, 2 pour légèrement actif, 3 pour modérément actif, 4 pour très actif, 5 pour extrêmement actif) : ");
activite = Convert.ToInt32(Console.ReadLine());

// Je déclare la variable besoinCalories pour le calcul des besoins caloriques journaliers :

double besoinCalories = 0;

// Je fais le calcul des besoins caloriques journaliers en fonction du niveau d'activité physique :

if (activite == 1)
{
    besoinCalories = BMR * 1.2;
}
else if (activite == 2)
{
    besoinCalories = BMR * 1.375;
}
else if (activite == 3)
{
    besoinCalories = BMR * 1.55;
}
else if (activite == 4)
{
    besoinCalories = BMR * 1.725;
}
else if (activite == 5)
{
    besoinCalories = BMR * 1.9;
}

// J'affiche le résultat du calcul des besoins caloriques journaliers :

Console.WriteLine("Vos besoins caloriques journaliers sont de : " + besoinCalories + " calories");

// c. Calcul des macronutriments :

// Pour calculer les macronutriments (protéines, lipides, glucides), il faut répartir les besoins caloriques journaliers en fonction des recommendations suivantes :

//     Protéines : 15-25% des calories
//     Lipides : 20-35% des calories
//     Glucides : le reste des calories

// Je déclare les variables pour les macronutriments :

double proteines = 0;
double lipides = 0;
double glucides = 0;

// Je fais le calcul des macronutriments en fonction des recommendations :

proteines = besoinCalories * 0.2;
lipides = besoinCalories * 0.3;
glucides = besoinCalories - proteines - lipides;

// J'affiche le résultat du calcul des macronutriments :

Console.WriteLine("Vous devez consommer : ");
Console.WriteLine("Protéines : " + proteines + " calories");
Console.WriteLine("Lipides : " + lipides + " calories");
Console.WriteLine("Glucides : " + glucides + " calories");

// Je convertis les calories en grammes pour les macronutriments :

proteines = proteines / 4;
lipides = lipides / 9;
glucides = glucides / 4;

// J'affiche le résultat du calcul des macronutriments en grammes :

Console.WriteLine("Soit en grammes : ");

Console.WriteLine("Protéines : " + proteines + " g");
Console.WriteLine("Lipides : " + lipides + " g");
Console.WriteLine("Glucides : " + glucides + " g");

// Je demande à l'utilisateur d'appuyer sur une touche pour fermer la console :

Console.WriteLine("Appuyez sur une touche pour fermer la console...");
Console.ReadKey();

// Fin du programme

