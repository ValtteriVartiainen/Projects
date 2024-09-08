let pelaajanKortit = [];
let tietokoneenKortit = [];
let peliKaynnissa = false;

function peliKortti() {
    return Math.floor(Math.random() * 13) + 1;
}

function kortinNimi(kortti) {
    if (kortti === 1) return "Ace";
    if (kortti === 11) return "J";
    if (kortti === 12) return "Q";
    if (kortti === 13) return "K";
    return kortti.toString();
}

function laskePisteet(kortit) {
    let pisteet = kortit.reduce((summa, kortti) => {
        if (kortti === 1) {
            return summa + 11;
        } else if (kortti === 11 || kortti === 12 || kortti === 13) {
            return summa + kortti;
        } else {
            return summa + kortti;
        }
    }, 0);

    let numOfAces = kortit.filter(kortti => kortti === 1).length;
    while (pisteet > 21 && numOfAces > 0) {
        pisteet -= 10;
        numOfAces--;
    }
    return pisteet;
}

function paivitaPeli() {
    const kortitNimet = pelaajanKortit.map(kortinNimi).join(', ');
    const pisteet = laskePisteet(pelaajanKortit);
    document.getElementById('pelaajanKortit').textContent = `Kortit: ${kortitNimet} (Yhteensä: ${pisteet})`;
}

function pelaaPeli() {
    pelaajanKortit = [peliKortti(), peliKortti()];
    tietokoneenKortit = [peliKortti(), peliKortti()];

    peliKaynnissa = true;

    paivitaPeli();
    
    const pelaajanPisteet = laskePisteet(pelaajanKortit);
    if (pelaajanPisteet === 21) {
        document.getElementById('tulos').textContent = `Voitit heti! Sinulla on ${pelaajanPisteet}.`;
        lopetaPeli();
        return;
    }

    document.getElementById('aloitaPeli').style.display = 'none';
    document.getElementById('nostaKortti').style.display = 'inline-block';
    document.getElementById('lopetaPeli').style.display = 'inline-block';

    document.getElementById('tulos').textContent = 'Peli käynnissä. Nosta kortti tai lopeta peli.';
}

function nostaaKortti() {
    if (!peliKaynnissa) return;

    const uusiKortti = peliKortti();
    pelaajanKortit.push(uusiKortti);
    paivitaPeli();

    const pelaajanPisteet = laskePisteet(pelaajanKortit);

    if (pelaajanPisteet === 21) {
        document.getElementById('tulos').textContent = `Voitit! Sinulla on ${pelaajanPisteet}.`;
        lopetaPeli();
    } else if (pelaajanPisteet > 21) {
        document.getElementById('tulos').textContent = `Hävisit! Sinulla on ${pelaajanPisteet}, tietokoneella on ${laskePisteet(tietokoneenKortit)}.`;
        lopetaPeli();
    }
}

function tietokoneenVuoro() {
    while (laskePisteet(tietokoneenKortit) < 17) {
        tietokoneenKortit.push(peliKortti());
    }
}

function lopetaPeli() {
    if (!peliKaynnissa) return;

    peliKaynnissa = false;

    document.getElementById('aloitaPeli').style.display = 'inline-block';
    document.getElementById('nostaKortti').style.display = 'none';
    document.getElementById('lopetaPeli').style.display = 'none';

    tietokoneenVuoro();

    const pelaajanPisteet = laskePisteet(pelaajanKortit);
    const tietokoneenPisteet = laskePisteet(tietokoneenKortit);

    let tulos = '';

    if (pelaajanPisteet > 21) {
        tulos = `Hävisit! Sinulla on ${pelaajanPisteet}, tietokoneella on ${tietokoneenPisteet}.`;
    } else if (tietokoneenPisteet > 21 || pelaajanPisteet > tietokoneenPisteet) {
        tulos = `Voitit! Sinulla on ${pelaajanPisteet}, tietokoneella on ${tietokoneenPisteet}.`;
    } else if (pelaajanPisteet === tietokoneenPisteet) {
        tulos = `Tasapeli! Sinulla on ${pelaajanPisteet}, tietokoneella on ${tietokoneenPisteet}.`;
    } else {
        tulos = `Hävisit! Sinulla on ${pelaajanPisteet}, tietokoneella on ${tietokoneenPisteet}.`;
    }

    document.getElementById('tulos').textContent = tulos;
}

document.getElementById('aloitaPeli').addEventListener('click', pelaaPeli);
document.getElementById('nostaKortti').addEventListener('click', nostaaKortti);
document.getElementById('lopetaPeli').addEventListener('click', lopetaPeli);
