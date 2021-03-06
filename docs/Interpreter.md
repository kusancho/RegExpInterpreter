# Interpreter
## Developers

To interpret your code, at first you need to create an abstract syntax tree by using `Interpreter.textToAST <string>`.
Then you can run the `Interpreter.run <AST>` to execute your program. 

### Another functions

* `processExpr (vDict: Dictionary<AST.VName, VType>) (expression: AST.Expr)` - return a result of a given expression in `VType` format.
* `processStmt (vDict: Dictionary<AST.VName, VType>) (stmt: AST.Stmt)` - gets an expression from statement and sets it's value to the dictionary with variable as a key.

### Example

``` f#
let program = "

let [x] = (a|b)caba
let [c] = isAcceptable \"acaba\" [x]
let [d] = isAcceptable \"1\" (1*)&(1?)
let [e] = findAll \"muxa\" (x|a)

print [c]
print [d]
print [e]"

let ast = Interpreter.parseProgramToAST program
Interpreter.run ast
```

Given code prints
    ```
    True
    True
    [(2, 3);(3, 4)]
    ```
into console.

## Users

There are three console commands in RegExpInterpreter.

* `--inputfile <file path>` - the path to the file with code.
* `--inputstring <string>` - the string with code.
* `--compute` - returns the result of interpretation of the code
	