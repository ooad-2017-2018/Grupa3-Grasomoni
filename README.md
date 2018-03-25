## Grupa 3: **_Grasomoni_**

1.	Čaušević Husein 
2.	Divjan Belmin 
3.	Ćorović Dalila

![logo](https://user-images.githubusercontent.com/37112792/37866324-837fa0fa-2f89-11e8-9c6c-929fa67b3118.jpg)


## Opis teme
Projekat na temu **Sarajevo eprevoz net** baziran je na praćenju gradskog prevoza putem GPS-a. Svrha sistema je omogućiti korisniku uvid u kretanje izvjesnih prevoznih sredstava. S tim u vezi, moguće je locirati poziciju po volji odabranog transportnog sistema, te procjenu kako prostorne tako i vremenske udaljenosti prevoza od tekućeg položaja korisnika. 
Korisniku ovog sistema pruža se mogućnost unosa svoje lokacije, ličnih podataka i stanice do koje želi da ide. Na taj način na osnovu broja pređenih stanica vršio bi se proračun karte koju je korisnik dužan isplatiti. 
Korisnik koji se registruje preko ove aplikacije, dobija potrošačku karticu na kojoj uplaćuje novac. Prednost koju ovaj korisnik ima je popust na redovnu cijenu karte zbog učestalog korištenja sistema. Sistem nalaže da korisnik provuče karticu na polazećoj stanici i krajnjoj kako bi se sa računa skinula odgovarajuća količina novca. 
Ovaj sistem pruža mnogobrojna poboljšanja trenutačnom gradskom prevozu, jedna od tih su:
- [x] Prijava potencijalnih kvarova na sistemu 
- [x] Pospiješen sistem naplate (time je postignuto da se ne vrednuje podjednako karta korisnika koji ide od prve do zadnje stanice kao korisnika koji ima značajno manji pređeni put)
- [x] Smanjenje gužve u prevozu. Ovo se postiže na način praćenja broja registrovanih tokom dana. Statističkim pregledom može se utvrditi period kada imamo prijavu kritičnog broja korisnika, te u tim satima povećati broj transportnih sredstava. 
- [x] Pregled prihoda I potrošnje
- [x] Popust na učestale korisnike, studente, penzionere, djecu i na rodbinu kreatora sistema (i na članove SDA)
- [x] Kvalitetniji sistem je direktno proporcionalan povećanju broja korisnika
- [x] Mjesečna karta je zamijenjena potrošačkom na kojoj korisnik uplaćuje novac, s tim da korisnik nije primoran da potroši sav novac u nekom vremenskom intervalu (kao što je slučaj sa istekom regularne mjesečne karte, a da korisnik nije iskoristio njenu "punu" vrijednost)

## Procesi 
-	_Proces registracije korisnika:_ prilikom pokretanja sistema korisnik unosi lične podatke. Lični podaci podrazumijevaju: ime, prezime, korisničko ime, JMBG i lozinka.
-	_Prijava:_ nakon registracije, za pristupanje interfejsu, korisnik koristi jedinstveno korisničko ime i lozinku
-	_Unos trenutne lokacije korisnika I željene stanice do koje korisnik želi doći, te odabir prevoznog sredstva_
-	_Proračun karte:_ na osnovu udaljenosti između početne I krajnje lokacije, vrši se izračunavanje cijene karte 
-	Nakon procjene karte, korisnik bira da li će potvrditi naplatu ili ne
-   _Provjera statistike od strane administratora_

## Funkcionalnosti
-	Registracija korisnika
-   Prijava korisnika koji je prethodno registrovan na sistem
-	Odabir željenog prevoznog sredstva 
-   Unos pozicije korisnika
-	Odabir lokacije na koju korisnik želi da dođe
-	Prikaz najbližeg prevoznog sredstva i vremenski period za koji bi vozilo trebalo da dođe
-	Proračun karte 
-	Uređivanje naloga

## Akteri
1.	Neregistrovani korisnik - osoba koja nije stalni korisnik sistema. Ima ambiciju pregleda raspoloživih prevoznih sredstava ili cijena koje se kreću na račun udaljenosti početne i krajnje lokacije. Kartu kupuje na stanici, da bi po izlazu kartu priložio kontroli tako da bude provjereno da li je korisnik izašao na lokaciji do koje karta važi.
2.  Registrovani korisnik - stalni korisnik aplikacije. Predviđeno je da ovaj korisnik prilikom registracije dobije svoju potrošačku karticu na kojoj će imati izvjesnu količinu novca. Korisnik karticu provuče na polazećoj lokaciji i krajnjoj, te se na osnovu proračuna sa kartice skida taj novac.
3.	Administrator: 
    - uvid u sistem
    - pristup korisničkim podacima
    - pristup registrovanim vozilima
    - odobravanje zahtjeva brisanja korisničkih naloga
    - blokiranje korisničkih naloga
4. Radnik - prodaje karte neregistrovanim korisnicima na uplatnim mjestima (stanicama)
5. Kontrola - provjera neregistrovanih i registrovanih korisnika na licu mjesta.
    
