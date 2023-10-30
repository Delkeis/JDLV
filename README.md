# JDLV
a Wpf/ C# organic simulation

Ce programme est une simulation organique de l'évolution de cellules basé sur une série de règles simples,
il à été réaliser en seulement quelques jours dans le cadre d'une épreuve de compétences.

This program is an organic simulation of cell evolution, based on a list of a simple rule,
this program was completed in just a few days as part of a skills test.

---------------------

Les règles pour une case sont définies par apport aux huit cases qui l'entoure.

The rules for a cell are defineing by input to the eight cells surrounding it.

---------------------

On considère une case noire comme vivante et une case blanche comme vide ou morte.

we are considering that a black cell is alive, and a white cell is empty or dead.

---------------------

Les règles sont les suivantes :

The rules are the following :


- Si une case noire n'est entourée que d'une seule case noire ou moins alors elle devient blanche.

  If a black cell is surrounded by one or less black cell, then the cell turn white.

![image](https://github.com/Delkeis/JDLV/assets/14760415/9c70d9ef-2efe-4090-8d23-2de4489d8ef2) -> ![image](https://github.com/Delkeis/JDLV/assets/14760415/acf11d4c-aef6-487d-85c5-52b6b2bfedc0)


- Si une case noire est entourée par deux ou trois cases noires, elle reste noire.

  If a black cell is surrounded by two or three black cells, she stay black.

![image](https://github.com/Delkeis/JDLV/assets/14760415/4f7e35ce-73f8-41b4-bd1c-d639cc0b0c4d)


- Si une case blanche est entourée deux cases noires, elle devient noire à son tour.

  If a white is surrounded by two black cells, she turn black.

![image](https://github.com/Delkeis/JDLV/assets/14760415/fd5038b0-5a29-44f8-bb3e-1dbd729fbd58) -> ![image](https://github.com/Delkeis/JDLV/assets/14760415/4ba2dffa-6f18-4351-800f-b1d178a7a1a8)

- Si une case noire est entourée de quatre cases noires ou plus, elle devient blanche.

  If a black cell is surrounded by four black cells or more, she turn white.

![image](https://github.com/Delkeis/JDLV/assets/14760415/05b4fae8-637f-454a-8399-3ad8a3619acb) -> ![image](https://github.com/Delkeis/JDLV/assets/14760415/724720d6-34cb-4ca7-8953-696f9f9c6ed4)

