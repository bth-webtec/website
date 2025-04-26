---
title: "README" 
description: No description.
revision:
    2025-04-25: (A, mos) Första versionen. 
---

:::note
Detta dokument är enbart för lärare.
:::

Detta dokument beskriver hur lärarna jobbar med utvecklingen av labbarna och hur labbar driftsätts hos studenterna.



## Provkör och testa labbar

Så här kan du testköra en labb, förutsatt att du har klonat repot.

```console title="Gå till katalogen som innehåller labbarna."
$ cd src/content/docs/laromaterial/lab
$ tree -L 1 .
.
├── README.md
├── eslint.config.js
├── lab_01
├── lab_02
├── lab_03
└── package.json
```

```console title="Kör en av labbarna med 'answer'-filen."
$ node lab_01/lab
❌ 1p. hello(), expected: "Hello world", actual: "Hi world"
❌ 1p. magicNumber(), expected: 42, actual: undefined
❌ 1p. stringNumber(42), expected: "42", actual: undefined
❌ 1p. stringLength("Hello world"), expected: 11, actual: undefined
❌ 1p. stringLength("cactus"), expected: 6, actual: undefined
❌ 1p. product(7, 6), expected: 42, actual: undefined
❌ 1p. sumValues(42.2, 34.5), expected: 76.7, actual: undefined
❌ 1p. sumFloatRoundedLower(42.2345, 34.55452), expected: 76, actual: undefined
❌ 1p. sumFloatRoundedHigher(245.567, 124.6543), expected: 371, actual: undefined
❌ 1p. diffFloatRoundedActual(76.887585, 42.543265), expected: 34.34, actual: undefined
❌ 1p. roundPI(), expected: 3.1416, actual: undefined
❌ 1p. concatinateString("Hello", "everyone"), expected: "Hello everyone", actual: undefined
❌ 1p. charAtPosition("JavaScript"), expected: "S", actual: undefined
❌ 1p. charAtPosition("programmering"), expected: "r", actual: undefined
❌ 1p. upper("programming"), expected: "PROGRAMMING", actual: undefined
❌ 1p. upper("webtec"), expected: "WEBTEC", actual: undefined
❌ 1p. upperFirst("programming"), expected: "Programming", actual: undefined
❌ 1p. upperFirst("javaScript"), expected: "JavaScript", actual: undefined
❌ 1p. substring("Polarbear"), expected: "ear", actual: undefined
❌ 1p. wordIncludes("Polarbear"), expected: true, actual: undefined
❌ 1p. wordIncludes("Lemon"), expected: false, actual: undefined

--------------------------------------------------------------------
| Total: 21, Passed ✅: 0, Failed ❌: 21
| Points needed to PASS=15, PASS WITH HONOUR=19, TOTAL=21
|  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  😁  ⦾  ⦾  ⦾  😍  ⦾  🙌 
| 
| You have 0 points. Try to earn 1 point to get started... 😏
--------------------------------------------------------------------
```

```console title="Kör en av labbarna med 'solution'-filen med -s."
$ node lab_01/lab -s
✅ 1p. hello(), expected: "Hello world", actual: "Hello world"
✅ 1p. magicNumber(), expected: 42, actual: 42
✅ 1p. stringNumber(42), expected: "42", actual: "42"
✅ 1p. stringLength("Hello world"), expected: 11, actual: 11
✅ 1p. stringLength("cactus"), expected: 6, actual: 6
✅ 1p. product(7, 6), expected: 42, actual: 42
✅ 1p. sumValues(42.2, 34.5), expected: 76.7, actual: 76.7
✅ 1p. sumFloatRoundedLower(42.2345, 34.55452), expected: 76, actual: 76
✅ 1p. sumFloatRoundedHigher(245.567, 124.6543), expected: 371, actual: 371
✅ 1p. diffFloatRoundedActual(76.887585, 42.543265), expected: 34.34, actual: 34.34
✅ 1p. roundPI(), expected: 3.1416, actual: 3.1416
✅ 1p. concatinateString("Hello", "everyone"), expected: "Hello everyone", actual: "Hello everyone"
✅ 1p. charAtPosition("JavaScript"), expected: "S", actual: "S"
✅ 1p. charAtPosition("programmering"), expected: "r", actual: "r"
✅ 1p. upper("programming"), expected: "PROGRAMMING", actual: "PROGRAMMING"
✅ 1p. upper("webtec"), expected: "WEBTEC", actual: "WEBTEC"
✅ 1p. upperFirst("programming"), expected: "Programming", actual: "Programming"
✅ 1p. upperFirst("javaScript"), expected: "JavaScript", actual: "JavaScript"
✅ 1p. substring("Polarbear"), expected: "ear", actual: "ear"
✅ 1p. wordIncludes("Polarbear"), expected: true, actual: true
✅ 1p. wordIncludes("Lemon"), expected: false, actual: false

--------------------------------------------------------------------
| Total: 21, Passed ✅: 21, Failed ❌: 0
| Points needed to PASS=15, PASS WITH HONOUR=19, TOTAL=21
|  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦾  ⦾  😍  ⦾  🙌 
| 
| You have 16 points. Great, you are on fire and progress is made. 😋
--------------------------------------------------------------------
```



## Poängberäkning i labben

Poängberäkningen i labbverktyget är delvis hårdkodat så att följande nivåer gäller för poängen som kan uppnås i en labb.

```js
  static PASS = 15
  static PASS_W_HONOUR = 19
  static PASS_TOTAL = 21
```

Feedbacken till studenten, i form av emojis, är beroende av dessa hårdkodade gränser.

```js
    if (points === 0) {
      msg = "Try to earn 1 point to get started... 😏"
    } else if (points === 1) {
      msg = "Nice work, lets go, do another! 😉"
    } else if (points === this.PASS - 3) {
      msg = "Just three more to PASS. Lets go. 😅"
    } else if (points === this.PASS - 2) {
      msg = "Just two more to PASS. Lets go. 😅"
    } else if (points === this.PASS - 1) {
      msg = "Just one more to PASS. Lets go. 😅"
    } else if (points === this.PASS) {
      msg = "Excellent, you have PASSED. One more? 😁"
    } else if (points === this.PASS_W_HONOUR - 2) {
      msg = "Two more to PASS WITH HONOUR! Lets go. 😅"
    } else if (points === this.PASS_W_HONOUR - 1) {
      msg = "One more to PASS WITH HONOUR! Lets go. 😅"
    } else if (points === this.PASS_W_HONOUR) {
      msg = "That is the way, you PASSED WITH HONOUR! 😍"
    } else if (points === this.PASS_TOTAL) {
      msg = "What can I say. You impress me. 🙌"
    }
```

Labben är uppbyggd av funktioner. En funktion kan ta argument och skall returnera ett värde. En funktion kan testas av en eller flera assertions. Alla assertions måste passeras för att man skall få poäng för funktionen.

Default är att varje funktion ger 1 poäng, vill man att en funktion skall vara värd mer så anger man det med ett optionellt fjärde argument, första gången man gör en assert på den funktionen.

```js ins="5"
dbw.assert(lab.isPalindrom, ['AbccbA'], true, 5)
dbw.assert(lab.isPalindrom, ['AbcbA'], true)
dbw.assert(lab.isPalindrom, ['Mumintroll'], false)
```

I ovan kod så är det 5 poäng för funktionen `isPalindrom`. Man anger poängen vid den första assertionen.

En lab kan innehålla godtyckligt antal funktioner, normalt vore max 21 funktioner (har inte testat eller funderat på att ge en halv poäng för en uppgift).

Troligen har man ofta färre antal funktioner på en labb och måste då finna en poängsättning så att totalpoängen alltid blir 21.

Flexibiliteten ligger alltså i att du kan ha godtydligt antal funktioner som du väljer poängsättning för men du skall alltid summera till 21.

Var inte rädd för att ge 5 poäng för en enklare funktion och sätta 1 poäng för de svåra funktionerna, även om det kan kännas avigt. Med poängen kan du styra vilka delar av labben som studenten utför.



## Använd utvecklingsverktyg

Du kan köra eslint när du står i översta katalogen där labbarna finns.

```console title="Varianter att köra eslint."
# Kör eslint för alla labbar
npm run eslint 
npm run eslint:fix

# Kör eslint för en specifik labb
npm run eslint lab_01
npm run eslint:fix lab_01
```



## Lägg till en ny uppgift (funktion) i en labb

Börja med att placera skalet för funktionen i filen `answer.js`. Som exempel använder vi en funktion som skall addera två tal och returnera summan av dem.

```js
/**
 * Returns the sum of two integer values.
 * 
 * @param {number} value1 - The first number to add.
 * @param {number} value2 - The second number to add.
 * @returns {number} The sum of the two values.
 */
export function add (value1, value2) {
  // TODO: Write your code here.
}
```

Utför en eller flera asserts för att testa funktionen, placera dessa asserts i filen `lab.js`.

```js
dbw.assert(lab.add, [], null)
```

Argumenten till assert-funktionen är namnet på funktionen som skall testas `lab.add`, en array med argument som skickas till funktionen `[]` samt vad funktionen förväntas returnera `null`.

Kör labben och försäkra dig om att det blir ett ❌ för testfallet. Om det inte blir utfallet så väljer du att returnera ett dummy-värde från funktionen så att det alltid blir en misslyckad assert till att börja med.

I detta exempel väljer jag att returnera -1 vilket gör att asserten inte uppfylls. I detta fallet kan jag även helt utelämna att returnera något, om det ger en misslyckad assert.

```diff lang="js"
/**
 * Returns the sum of two integer values.
 * 
 * @param {number} value1 - The first number to add.
 * @param {number} value2 - The second number to add.
 * @returns {number} The sum of the two values.
 */
export function add (value1, value2) {
  // TODO: Write your code here.
+  return -1
}
```

Nu fyller vi på med fler testfall i form av assertions.

```js
dbw.assert(lab.add, [], null)
dbw.assert(lab.add, [1], null)
dbw.assert(lab.add, [1, 1], 2)
```

Kör labben så att du ser att alla assertions misslyckas.

```console title="Alla assertions misslyckas nu."
$ node lab
❌ 1p. add(), expected: null, actual: -1
❌ 1p. add(1), expected: null, actual: -1
❌ 1p. add(1, 1), expected: 2, actual: -1
```

Nu kan du kopiera funktionen till `solution.js` och implementera den med ett lösningsförslag. När du är klar så kör du labben med lösningsfilen, för att dubbelkolla att alla assertions passerar.

```console title="Alla assertions bör passera när solutions används."
$ node lab -s
✅ 1p. add(), expected: null, actual: null
✅ 1p. add(1), expected: null, actual: null
✅ 1p. add(1, 1), expected: 2, actual: 2
```

Nu är du redo att lägga till ytterligare en funktion i din labb.



## Utmaningen att skriva bra funktioner till labben

Det finns en utmaning i att skriva bra funktioner till labbarna.

Det kan vara lämpligt att inleda med enkla funktioner så att studenten kommer igång. Därefter gör man funktionerna svårare och svåra medans de allra sista kan vara lagom utmanande.

När labbarna blir allt svårare så kan man även låta studenterna återanvända funktioner de tidigare skrivit i labben.

När man gör labbar med klasser (eller moduler) så kan de definieras i externa filer som importeras till `answer.js` och på det sättet blir varje funktion i labben som en litet main-program.

Man bör testa och fila på sina labb-funktioner så att de ger önskat lär-resultat för studenten, med tanke på de lärmoment man utför tillsammans med labben.

Gör även efterföljande uppgifter där studenten kan dra nytta av lärdomar från labben. Det ger ytterligare motivation till att utföra labben innan man gör uppgifterna.

Det är troligen rimligt att låta studenten ta del av `solutions.js` så att den själv kan bestämma om den vill tjuvkika på lösningar. Ibland kan det vara bra att visa olika typer av lösningar, när det är lämpligt. Till exempel kan man lösa en uppgift med antingen `for()` eller `foreach()` och båda lösningarna kan visas.

Använd gärna labb-funktioner som material för genomgång och handledning. Det ger en möjlighet att skriva små kodstycken med ett tydligt fokus och det ger möjlighet att fokusera på hur läraren tänker kring problemlösning då koden skapas steg för steg.

Försök finna en råd tråd genom labben så att uppgifterna hänger ihop på ett lämpligt sätt.

Gör funktioner så att studenten kan gå tillbaka till labben för att se hur de löste en viss sak i labben.

Se till att du kan hjälpa studenten med liknande kommentarer:

> Ah, men du minns kanske att vi löste ett sådant problem i slutet av lab 2, eller hur?



## Att göra

Följande är förbättringsförslag.



### Förtydliga utskriften av summeringen

Det kan vara svårt att se raden som visar antalet "poäng" och de funktioner/poäng som man "träffat".

```console title="Inga poäng är tagna."
|  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  😁  ⦾  ⦾  ⦾  😍  ⦾  🙌 
```

```console title="10 poäng är avklarade."
|  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦾  ⦾  ⦾  ⦾  😁  ⦾  ⦾  ⦾  😍  ⦾  🙌 
```

```console title="Samtliga 21 poäng är tagna."
|  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿  ⦿ 
```

Kanske kan man färgkoda när en funktion/poäng är avklarad, eller förhöja synligheten när det är avklarat.



### Begränsa utskriften

Man kan begränsa utskriften för studenten så att det enbart blir en utskrift för varje funktion där alla assertions passeras. Det begränsar informationen som skrivs ut i terminalen och ger en bättre översikt.

Om en assertion går fel så skriver man ut alla assertions för den funktionen.

Det bör finnas med en debug-variant där samliga assertions skrivs ut.



## Dokumentation

En labb består av följande filer.



### Lärarens vy

Dessa filern är aktuella när läraren jobbar med utveckling av labbar.

| Filnamn | Innehåll |
|---------|----------|
| `src/dbw.js` | Verktyget för att köra labben, här finns insamling av statistik, funktioner för att utföra assertions och för att skriva ut en avslutande summering av labben. |
| `src/lab.html` | Mall för att köra en labb i webbläsaren och labben exekveras i devtools console. |
| `lab_0x/README.md` | Beskrivning av labben som studenten kan läsa för att se vad labben handlar om och hur man kommer igång med labben. |
| `lab_0x/lab.js` | Main-programmet för att köra labben med assertions, här importeras det som behövs och alla assertions körs. |
| `lab_0x/answer.js` | Alla (tomma) funktioner som studenten skall implementera för att utföra labben. |
| `lab_0x/solution.js` | Lösningar till labben, studenten kan ha tillgång till dessa för att se olika alternativ för implementation av en funktion. |



### Studentens vy

När studenten jobbar med labbar skall de placeras i en katalogstruktur för att underlätta koppling mot GitHub actions.

```console title="Katalogstruktur för labbar i underkatalog i studentens repo."
$ tree lab -L 1
../lab
├── lab_01
├── lab_02
├── lab_03
```

Dessa filer ser studenten i respektive lab-katalog när de skall jobba med labben.

| Filnamn | Innehåll |
|---------|----------|
| `README.md` | Beskrivning av labben som studenten kan läsa för att se vad labben handlar om och hur man kommer igång med labben. |
| `lab.html` | Öppna i webbläsaren för att exekvera labben i devtools console. |
| `lab.js` | Main-programmet för att köra labben med assertions, här importeras det som behövs och alla assertions körs. |
| `answer.js` | Alla (tomma) funktioner som studenten skall implementera för att utföra labben. |
| `solution.js` | Lösningar till labben, studenten kan ha tillgång till dessa för att se olika alternativ för implementation av en funktion. |

När labben distribueras till studenten så inkluderas koden för `dbw.js` in i filen `lab.js` för att minska antalet filer som distribueras.



## Distribution av labb till studentens repo

Exakt format för hur vi väljer att distribuera labben till studentens repo kvarstår att bestämma.

En variant är att vi minskar antalet filer som studenten behöver och inkluderar `dbw.js` in i `lab.js`.

En variant är att importera allt som behövs överst i `lab.js` från en webbplats och på det sättet behöver studenten enbart en fil i sitt repo.

Studenten kan använda `curl` för att ladda hem en lab. Om en lab består av flera filer kan nedladdning alternativt ske genom ett skript som laddas med curl från github och pipas in i bash.

Studenten kan välja att köra labben via node `node lab` eller via webbläsaren `lab.html`.
