sync više mojih kalendara
email obavijest o novom unosu
koristiti config fileove, ne admin sučelje - više kalendara sa kojima se synca
Icalendar format - ICS file
		 - "free busy"
		 
0.5 - CI/CD napraviti odmah za projekt (docker image) - public repozitorij, ne treba server u tom slučaju
	- lokalni test da li je image publishiran - "docker run ..."
1. kako exposaty svoj kalendar kao free busy u ICS formatu. U aplikaciji odi na svaki url, učitaj ICS, parsati i uvesti u bazu.
2. Slati na odeđene adrese "free-busy" zahtjev za sastankom
3. Odobravanje samog sastanka - mail sa "da" "ne", ako je DA slati meeting request ako su svi prihvatili samo da im se unese u kalendar
	- Možda stvoriti required i optional "korisnike"
	
Calendly.com - radi ideje
**stvoriti konzolne aplikacije kako bi atomarno testirao navedene stvari PRIJE samog kreiranaj Blazora

4. Blazor prikaži kalendar (free-busy - kao free i busy blokove)




blazor server side
