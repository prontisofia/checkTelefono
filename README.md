# checkTelefono

Il progetto CheckTelefono ornisce una semplice validazione per i numeri di telefono all'interno di un array di stringhe. Questo codice è organizzato in una classe chiamata Telefono, che contiene un metodo statico denominato Check responsabile della validazione dei numeri di telefono forniti come input. 

Lo scopo è verificare se un numero di telefono è valido o meno, in base a determinati criteri. Il codice accetta un array di stringhe input, ciascuna delle quali rappresenta un numero di telefono, e restituisce il primo numero che soddisfa i seguenti criteri di validità:
- Il numero inizia con "+39" ed è composto da 13 caratteri.
- Il numero inizia con "0039" ed è composto da 14 caratteri.
- Il numero inizia con "3" ed è composto da 10 caratteri.

Se uno qualsiasi di questi criteri è soddisfatto per un numero, il numero viene restituito come valido. In caso contrario, l'elemento dell'array viene contrassegnato come "Non Valido". Se nessun numero valido viene trovato nell'array, il metodo restituirà una stringa vuota. 
