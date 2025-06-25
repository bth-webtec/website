---
title: "README" 
description: Kursdokumentation för lärare.
revision:
  2025-06-24: (A, mos) Första versionen. 
---

:::note
Detta dokument är enbart för lärare.
:::

Detta dokument beskriver hur en lärare kan skapa ett kursrepo likt det studenterna har, på enklaste möjliga sätt. Detta sätt kan även en student använda sig av, om man av någon anledning inte vill eller kan jobba igenom den guiden som visa hur man gör.



## Klona ett exempel repo

Det finns ett [repo `webtec-abcd25`](https://github.com/bth-webtec/webtec-abcd25) som används i guiden och det är skapat enligt guiden. Detta repo innehåller också samtliga utvecklingsverktyg som behövs innan man kan sätta igång med kmom01.

Börja med att ange det namn du vill ha på ditt repo.

```bash title="Ange namnet på ditt blivande repo."
# Set an environment variable with the repo name
REPO=webtec-vxyz25
```

Nu kan du klona det exiterande repot och placera det i en katalog som matchar ditt önskade repo namn.

```bash title="Klona det befintliga repot och alla dess delar."
# Clone the existing repo as a mirror
git clone --mirror git@github.com:bth-webtec/webtec-abcd25.git $REPO
cd $REPO
```

Du behöver nu skapa ett nytt repo på GitHub som du vill koppla ditt lokala repo till.

När det är klart kan du koppla ditt lokala repo till den nyskapade platsen på GitHub.

```bash title="Koppla det lokala repot till platsen på GitHub."
# Connect your local repo with the place at GitHub
git remote set-url origin git@github.com:bth-webtec/$REPO.git
git push --mirror
```

Nu är det klart och du kan börja jobba med ditt repo.
