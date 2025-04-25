---
title: "README" 
description: No description.
---

:::note
Dett dokument är enbart för lärare.
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
$ node lab_01_FIXED/lab -s
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



## Använd utvecklingsverktyg

Du kan köra eslint när du står i översta katalogen.

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
dbw.assert(lab.add, [], undefined)
```

Argumenten till assert-funktionen är namnet på funktionen som skall testas, en array med argument som skickas till funktionen samt vad funktionen förväntas returnera.

Kör labben och försäkra dig om att det blir ett ❌ för testfallet. m det inte blir utfallet så väljer du att returnera ett dummy-värde från funktionen så att det alltid blir en negativ assert till att börja med.

I detta exempel väljer jag att returnera -1 vilket gör att asserten ger fel.

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
  return -1
}
```

Nu fyller vi på med fler testfall i form av assertions.

```js

```


## Att göra

Följande är förbättringsförslag.



### Förtydliga utskriften av summeringen

Det kan vara svårt att se raden som visar antalet "poäng" och de funktioner/poäng som man "träffat".

```console
|  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  😁  ⦾  ⦾  ⦾  😍  ⦾  🙌  ⦾ 
```

Kanske kan man färgkoda när en funktion/poäng är avklarad, eller förhöja synligheten när det är avklarat.



### Begränsa utskriften

Man kan begränsa utskriften för studenten så att det enbart blir en utskrift för varje funktion där alla assertions passeras. Det begränsar informationen som skrivs ut i terminalen och ger en bättre översikt.

Om en assertion går fel så skriver man ut alla assertions för den funktionen.

Det bör finnas med en debug-variant där samliga assertions skrivs ut.
