# checkTelefono

Il progetto CheckTelefono ornisce una semplice validazione per i numeri di telefono all'interno di un array di stringhe. Questo codice è organizzato in una classe chiamata Telefono, che contiene un metodo statico denominato Check responsabile della validazione dei numeri di telefono forniti come input. 

Lo scopo è verificare se un numero di telefono è valido o meno, in base a determinati criteri. Il codice accetta un array di stringhe input, ciascuna delle quali rappresenta un numero di telefono, e restituisce il primo numero che soddisfa i seguenti criteri di validità:
- Il numero inizia con "+39" ed è composto da 13 caratteri.
- Il numero inizia con "0039" ed è composto da 14 caratteri.
- Il numero inizia con "3" ed è composto da 10 caratteri.

Se uno qualsiasi di questi criteri è soddisfatto per un numero, il numero viene restituito come valido. In caso contrario, l'elemento dell'array viene contrassegnato come "Non Valido". Se nessun numero valido viene trovato nell'array, il metodo restituirà una stringa vuota. 

Il codice è composto da una singola classe chiamata Telefono.

- public static string Check(string[] input):
  Questo è il metodo di validazione che accetta un array di stringhe input come argomento. All'interno del metodo, vi sono due cicli for annidati. Il primo ciclo scorre attraverso ciascun elemento dell'array input, mentre il secondo ciclo scorre attraverso ciascun carattere all'interno di ogni stringa. Durante questo processo, il metodo verifica se ogni carattere non è un numero (0-9) e non è il carattere '+'. Se un carattere non soddisfa questi criteri, la stringa corrispondente nell'array viene contrassegnata come "Non Valido".
- Dopo la fase di validazione dei caratteri, il codice entra in un altro ciclo foreach che itera attraverso le stringhe dell'array input. Per ogni stringa, vengono verificati i criteri di validità seguendo le condizioni elencate in precedenza. Se uno qualsiasi di questi criteri è soddisfatto per un numero, il numero viene restituito come valido attraverso l'istruzione return.
- Se nessun numero valido viene trovato durante l'iterazione dell'array, il metodo restituisce una stringa vuota "" per indicare l'assenza di numeri validi.
