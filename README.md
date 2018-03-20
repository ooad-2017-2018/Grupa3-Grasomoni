## Grupa 3: **_Grasomoni_**

1.	Čaušević Husein 
2.	Divjan Belmin 
3.	Ćorović Dalila

## Opis teme
Projekat na temu **Sarajevo eprevoz net** baziran je na praćenju gradskog prevoza putem GPS-a. Svrha sistema je omogućiti korisniku uvid u kretanje izvjesnih prevoznih sredstava. S tim u vezi, moguće je locirati poziciju po volji odabranog transportnog sistema, te procjenu kako prostorne tako i vremenske udaljenosti prevoza od tekućeg položaja korisnika. 
Korisniku ovog sistema pruža se mogućnost unosa svoje lokacije, ličnih podataka i stanice do koje želi da ide. Na taj način na osnovu broja pređenih stanica vršio bi se proračun karte koju je korisnik dužan isplatiti. 
Ovaj sistem pruža mnogobrojna poboljšanja trenutačnom gradskom prevozu, jedna od tih su:
- [x] Prijava potencijalnih kvarova na sistemu 
- [x] Pospiješen sistem naplate (time je postignuto da se ne vrednuje podjednako karta korisnika koji ide od prve do zadnje stanice kao korisnika koji ima značajno manji pređeni put)
- [x] Smanjenje gužve u prevozu. Ovo se postiže na način praćenja broja registrovanih tokom dana. Statističkim pregledom može se utvrditi period kada imamo prijavu kritičnog broja korisnika, te u tim satima povećati broj transportnih sredstava. 
- [x] Pregled prihoda I potrošnje
- [x] Popust na učestale korisnike, studente, penzionere, djecu i na rodbinu kreatora sistema (i na članove SDA)
- [x] Kvalitetniji sistem je direktno proporcionalan povećanju broja korisnika

## Procesi 
-	_Proces registracije korisnika:_ prilikom pokretanja sistema korisnik unosi lične podatke. Lični podaci podrazumijevaju: ime, prezime, JMBG, adresa stanovanja, kontakt telefon, email i lozinka.
-	_Prijava:_ Registrovani korisnik pošto naredni put pristupi interfejsu za prijavu, unosi svoje ime, prezime, lozinku, način plaćanja
-	_Unos trenutne lokacije korisnika I željene stanice do koje korisnik želi doći, te odabir prevoznog sredstva_
-	_Proračun karte:_ na osnovu udaljenosti između početne I krajnje lokacije, vrši se izračunavanje cijene karte 
-	Nakon procjene karte, korisnik bira da li će potvrditi naplatu ili ne
-   _Provjera statistike od strane administratora_

## Funkcionalnosti
-	Registracija korisnika ili prijava ukoliko prethodno imamo kreiran račun
-	Prikaz trenutne pozicije korisnika 
-	Odabir željenog prevoznog sredstva 
-	Odabir lokacije na koju korisnik želi da dođe
-	Prikaz najbližeg prevoznog sredstva i vremenski period za koji bi vozilo trebalo da dođe
-	Proračun karte 
-	Mogućnost elektronske naplate

## Akteri
1.	Neregistrovani korisnik - osoba koja nije stalni korisnik sistema. Ima ambiciju pregleda raspoloživih prevoznih sredstava ili cijena koje se kreću na račun udaljenosti početne i krajnje lokacije.
2.  Registrovani korisnik - stalni korisnik aplikacije.
3.	Administrator: 
    - uvid u sistem
    - pristup korisničkim podacima
    - pristup registrovanim vozilima
    - odobravanje zahtjeva brisanja korisničkih naloga
