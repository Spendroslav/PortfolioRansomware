# Ransomware
C# program, který po spuštění zašifruje velkou část souborů na disku pomocí šifrovacího algoritmu TripleDES a následně spustí vyděračskou zprávu, která žádá o výkupné.

-Při spuštětí:

-spustí se proces Form1, který ihned spustí Form2 (Zdrojový kod obsahuje část kodu, který spustí Form2 po nějakém časovém úseku, kdy obět nehýbe s myší)

-Form2:

-Vytvoří heslo, které má 16 znaků a pro zmatení vygeneruje navíc 34 znaků, po určení hesla začne vyhledávát soubory, které je možné zašifrovat.

-Po došifrování se spustí RansomNote, který oznamuje oběti, co se stalo a jak může získat své soubory zpět (Prvních 16 znaků "ID" v RansomNotu je heslo, zbytek má účel pouze máct. 
