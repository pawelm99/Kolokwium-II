using System;
using System.Collections.Generic;
using System.Data;
using System.IO;








/*Stwórz klasę Wiadomosc, która będzie miała pola Tresc (tekst) i Czas(data). 
Stwórz listę typu Wiadomosc i wygeneruj 10 wiadomości o dowolnej treści i losowej dacie. 
Daj użytkownikowi możliwość szukania wiadomości po części treści (np. 1 słowie - wprowadź dowolną zmianę 
do treści jednej wiadomości by dało się ją odszukać) a także pierwsze 3 wiadomości po dacie, którą podał użytkownik.*/

/*Stwórz generyczną klasę DictionaryBuilder, która przyjmie dwa typy (dla przykładu, A i B). Do klasy dodaj metodę BuildDictionary, 
która jako parametr przyjmie listę typu A i listę typu B a jako wynik zwróci słownik typu <A,B>. Metoda powinna sprawdzać czy obie 
listy mają tyle samo elementów. Jeśli nie, rzuć dowolny wyjątek. 
Jeśli tak, stwórz słownik z elementów obu list w taki sposób, by i-ty element listy A był kluczem dla i-tej wartości z listy B. 
Możesz założyć że elementy na liście A będą unikalne. Stwórz dwie krótkie listy i stwórz z nich słownik.*/

/*Stwórz interfejs ILogger z metodą Zaloguj, która przyjmuje jako parametr treść i enum z poziomem (info, warning, error).
Stwórz dwie klasy implementujące ten interfejs - LoggerKonsola i LoggerPlik. 
LoggerKonsola powinien wypisywać informację na konsolę w formacie [czas][poziom]: [treść].
LoggerPlik powinien logować wpisy z podziałem na pliki w zależności od poziomu loga. Do plików dodawaj wpisy w formacie [czas]: [treść]. 
Stwórz dowolną kolekcję typu ILogger i dla każdego elementu wywołaj funkcję Zaloguj z dowolnymi parametrami.*/