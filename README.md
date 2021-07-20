# MakeGame
1. Postoji dve vrste heroja i svaki heroj ima određeni “health”:
● Čarobnjak - 150 health-a
● Mačevalac - 100 health-a
2. Svaki heroj može da uzima i baca oružje:
● Mač ( nije dozvoljeno čarobnjaku da ga uzme, baciti exception)
● Koplje ( nije dozvoljeno čarobnjaku da ga uzme, baciti exception)
● Čarolija ( samo čarobnjak može da je nauči)
3. Heroj može da čuva oružja unutar ranca i samo jedno oružje je aktivno u jednom
trenutku. Kada heroj menja oružja, ako je torba prazna treba baciti NoWeapon
exception, oružja se menjaju po indexu u array-u. Kada jedan heroj baci oružje,
drugi heroj može da pokupi to oružje, a prvi heroj uzima sledeće slobodno oružje iz
ranca.
4. Maksimalan broj oružja u rancu je 2 . Ako igrač proba da doda još treba baciti
Exception.
5. U igrici postoje čudovišta:
● Zmaj
● Pauk
6. Svako čudoviste ima različiti način na koji napada (izabrati pomoću random
generatora koji je napad). Kada čudoviste napadne heroja ono mu nanosi štetu:
● Zmaj - ( Udara - skida 5 health-a, Bljuje vatru - skida 20 health-a)
● Pauk - ( Udara - skida 5 health-a, Ujeda - skida 8 health-a)
7. Heroj može da napadne čudovišta i nanosi im štetu:
● Čarobnjak, Čarolija - 20 health-a
● Mačevalac, Mač - 10 health-a
● Mačevalac, Koplje - 15 health-a
8. Potrebno je simulirati par stvari:
● Borbu između heroja i čudovista - Na osnovu random generatora uzimati broj
izmedju 0 i 100. Ako je broj ispod 50 napada heroj , ako je broj veći od 50
napada čudovište . Kada jednom od njih health padne na 0, drugo se
proglašava pobednikom.
● Kako jedan heroj kupi oružje i kako baca oružje. Oružje koje jedan heroj baci
simulirati kako bi drugi pokupio.
9. Potrebno je logovati u fajl:
● Svaki napad i koliku je štetu naneo taj napad, format:
[napadač] je napao [žrtvu] pomoću [oružja]
● Koje oružje je heroj pokupio, format:
[heroj] je pokupio oružje [oružje]
● Proglašavanje pobednika, format:
[heroj/čudovište] je pobedio u duelu sa [heroj/čudovište]
