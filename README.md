# Markov Text Transformer

Markov Text Transformer este o aplicatie de transformare a unui sir de caractere, provenit de la input-ul utilizatorului, intr-un alt sir de caractere, pe baza unor reguli specifice.

Aplicatia functioneaza conform principiul algoritmului lui Markov, unde avem un cuvant initial si o lista ordonata de reguli, de forma left -> right. Ideea principala este urmatoarea: se cauta prima regula din lista de reguli, care poate fi aplicata pe cuvantul nostru; se va repeta acest procedeu pana cand nu se mai poate aplica nicio regula din lista de reguli sau am ajuns la regula terminala (o regula speciala de oprire a algoritmului).

In cazul nostru, utilizatorul introduce string-ul initial, alege un substring, care trebuie sa fie inclus in string-ul initial, o operatie din lista prestabilita (unde se regasesc urmatoarele operatii: eliminare substring, inlocuire subtring, adaugare inainte, adaugare dupa si adaugare inainte + dupa), iar la final, se va afisa modul de functionare a algoritmului, unde la ultima regula aplicata se va gasi rezultatul nostru.

## Despre Algoritmul Markov

Daca doriti sa aflati mai multe informatii despre cum functioneaza mai exact algoritmul Markov, puteti accesa urmatorul link: https://en.wikipedia.org/wiki/Markov_algorithm

## Programe si limbaje utilizate

- Visual Studio Community 2022 (folosind limbajul C#)
- .NET Framework 4.7.2

## Cum sa rulati programul?

1. (Nu necesita programul Visual Studio Community 2022!!!) 
Faceti dublu-click pe executabilul "Markov_Text_Transformer.exe" din locatia "Markov_Text_Transformer\bin\Debug";

2. (Necesita programul Visual Studio Community 2022 sau un alt program compatibil!!!) 
Faceti dublu-click pe fisierul "Markov_Text_Transformer.sln", apoi apasati tasta F5 ca sa rulati codul si sa va porneasca aplicatia.

## Ce am invatat din realizarea acestui proiect?

- Modul de functionare al unui algoritm de rescriere/transformare a unui string dat (algoritmul Markov);
- Aplicarea acestui algoritm intr-un proiect real;
- Cum sa creez si sa personalizezi o aplicatie de tip Windows Forms, cu .NET Framework;
- Cum sa folosesc corect si eficient Toolbox-ul din meniul destinat crearii interfetei grafice.
