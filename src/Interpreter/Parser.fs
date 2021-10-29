// Implementation file for parser generated by fsyacc
module Parser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open FSharp.Text.Lexing
open FSharp.Text.Parsing.ParseHelpers
# 1 "Parser.fsy"



# 10 "Parser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | STR of (string)
  | EQ
  | KW_PRINT_TO_DOT
  | KW_IS_ACCEPTABLE
  | KW_FIND_ALL
  | KW_PRINT
  | KW_LET
  | VNAME of (string)
  | AMP
  | OPT
  | RBR
  | LBR
  | STAR
  | ALT
  | SMB of (char)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_STR
    | TOKEN_EQ
    | TOKEN_KW_PRINT_TO_DOT
    | TOKEN_KW_IS_ACCEPTABLE
    | TOKEN_KW_FIND_ALL
    | TOKEN_KW_PRINT
    | TOKEN_KW_LET
    | TOKEN_VNAME
    | TOKEN_AMP
    | TOKEN_OPT
    | TOKEN_RBR
    | TOKEN_LBR
    | TOKEN_STAR
    | TOKEN_ALT
    | TOKEN_SMB
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_stmt
    | NONTERM_expr
    | NONTERM_regexp_full
    | NONTERM_regexp
    | NONTERM_seq
    | NONTERM_seq_elem
    | NONTERM_vname
    | NONTERM_eof

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | STR _ -> 1 
  | EQ  -> 2 
  | KW_PRINT_TO_DOT  -> 3 
  | KW_IS_ACCEPTABLE  -> 4 
  | KW_FIND_ALL  -> 5 
  | KW_PRINT  -> 6 
  | KW_LET  -> 7 
  | VNAME _ -> 8 
  | AMP  -> 9 
  | OPT  -> 10 
  | RBR  -> 11 
  | LBR  -> 12 
  | STAR  -> 13 
  | ALT  -> 14 
  | SMB _ -> 15 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_STR 
  | 2 -> TOKEN_EQ 
  | 3 -> TOKEN_KW_PRINT_TO_DOT 
  | 4 -> TOKEN_KW_IS_ACCEPTABLE 
  | 5 -> TOKEN_KW_FIND_ALL 
  | 6 -> TOKEN_KW_PRINT 
  | 7 -> TOKEN_KW_LET 
  | 8 -> TOKEN_VNAME 
  | 9 -> TOKEN_AMP 
  | 10 -> TOKEN_OPT 
  | 11 -> TOKEN_RBR 
  | 12 -> TOKEN_LBR 
  | 13 -> TOKEN_STAR 
  | 14 -> TOKEN_ALT 
  | 15 -> TOKEN_SMB 
  | 18 -> TOKEN_end_of_input
  | 16 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_start 
    | 3 -> NONTERM_stmt 
    | 4 -> NONTERM_stmt 
    | 5 -> NONTERM_stmt 
    | 6 -> NONTERM_expr 
    | 7 -> NONTERM_expr 
    | 8 -> NONTERM_expr 
    | 9 -> NONTERM_regexp_full 
    | 10 -> NONTERM_regexp_full 
    | 11 -> NONTERM_regexp 
    | 12 -> NONTERM_regexp 
    | 13 -> NONTERM_seq 
    | 14 -> NONTERM_seq 
    | 15 -> NONTERM_seq_elem 
    | 16 -> NONTERM_seq_elem 
    | 17 -> NONTERM_seq_elem 
    | 18 -> NONTERM_seq_elem 
    | 19 -> NONTERM_seq_elem 
    | 20 -> NONTERM_vname 
    | 21 -> NONTERM_eof 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 18 
let _fsyacc_tagOfErrorTerminal = 16

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | STR _ -> "STR" 
  | EQ  -> "EQ" 
  | KW_PRINT_TO_DOT  -> "KW_PRINT_TO_DOT" 
  | KW_IS_ACCEPTABLE  -> "KW_IS_ACCEPTABLE" 
  | KW_FIND_ALL  -> "KW_FIND_ALL" 
  | KW_PRINT  -> "KW_PRINT" 
  | KW_LET  -> "KW_LET" 
  | VNAME _ -> "VNAME" 
  | AMP  -> "AMP" 
  | OPT  -> "OPT" 
  | RBR  -> "RBR" 
  | LBR  -> "LBR" 
  | STAR  -> "STAR" 
  | ALT  -> "ALT" 
  | SMB _ -> "SMB" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | STR _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | EQ  -> (null : System.Object) 
  | KW_PRINT_TO_DOT  -> (null : System.Object) 
  | KW_IS_ACCEPTABLE  -> (null : System.Object) 
  | KW_FIND_ALL  -> (null : System.Object) 
  | KW_PRINT  -> (null : System.Object) 
  | KW_LET  -> (null : System.Object) 
  | VNAME _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | AMP  -> (null : System.Object) 
  | OPT  -> (null : System.Object) 
  | RBR  -> (null : System.Object) 
  | LBR  -> (null : System.Object) 
  | STAR  -> (null : System.Object) 
  | ALT  -> (null : System.Object) 
  | SMB _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us;65535us;2us;65535us;0us;1us;2us;3us;2us;65535us;0us;2us;2us;2us;1us;65535us;8us;9us;5us;65535us;8us;13us;15us;16us;18us;19us;21us;22us;30us;31us;6us;65535us;8us;20us;15us;20us;18us;20us;21us;20us;24us;25us;30us;20us;7us;65535us;8us;23us;15us;23us;18us;23us;21us;23us;24us;23us;26us;27us;30us;23us;7us;65535us;8us;26us;15us;26us;18us;26us;21us;26us;24us;26us;26us;26us;30us;26us;10us;65535us;4us;5us;6us;7us;8us;29us;10us;11us;15us;29us;18us;29us;21us;29us;24us;29us;26us;29us;30us;29us;0us;65535us;|]
let _fsyacc_sparseGotoTableRowOffsets = [|0us;1us;4us;7us;9us;15us;22us;30us;38us;49us;|]
let _fsyacc_stateToProdIdxsTableElements = [| 1us;0us;1us;0us;2us;1us;2us;1us;2us;1us;3us;1us;3us;1us;4us;1us;4us;1us;4us;1us;4us;1us;5us;1us;5us;1us;5us;1us;6us;1us;7us;1us;7us;1us;7us;1us;8us;1us;8us;1us;8us;2us;9us;10us;1us;10us;1us;10us;2us;11us;12us;1us;12us;1us;12us;4us;13us;14us;18us;19us;1us;14us;1us;15us;1us;16us;1us;17us;1us;17us;1us;17us;1us;18us;1us;19us;1us;20us;|]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us;2us;4us;7us;9us;11us;13us;15us;17us;19us;21us;23us;25us;27us;29us;31us;33us;35us;37us;39us;41us;44us;46us;48us;51us;53us;55us;60us;62us;64us;66us;68us;70us;72us;74us;76us;|]
let _fsyacc_action_rows = 36
let _fsyacc_actionTableElements = [|3us;32768us;3us;10us;6us;4us;7us;6us;0us;49152us;3us;16385us;3us;10us;6us;4us;7us;6us;0us;16386us;1us;32768us;8us;35us;0us;16387us;1us;32768us;8us;35us;1us;32768us;2us;8us;5us;32768us;4us;17us;5us;14us;8us;35us;12us;30us;15us;28us;0us;16388us;1us;32768us;8us;35us;1us;32768us;1us;12us;0us;16389us;0us;16390us;1us;32768us;1us;15us;3us;32768us;8us;35us;12us;30us;15us;28us;0us;16391us;1us;32768us;1us;18us;3us;32768us;8us;35us;12us;30us;15us;28us;0us;16392us;1us;16393us;9us;21us;3us;32768us;8us;35us;12us;30us;15us;28us;0us;16394us;1us;16395us;14us;24us;3us;32768us;8us;35us;12us;30us;15us;28us;0us;16396us;5us;16397us;8us;35us;10us;34us;12us;30us;13us;33us;15us;28us;0us;16398us;0us;16399us;0us;16400us;3us;32768us;8us;35us;12us;30us;15us;28us;1us;32768us;11us;32us;0us;16401us;0us;16402us;0us;16403us;0us;16404us;|]
let _fsyacc_actionTableRowOffsets = [|0us;4us;5us;9us;10us;12us;13us;15us;17us;23us;24us;26us;28us;29us;30us;32us;36us;37us;39us;43us;44us;46us;50us;51us;53us;57us;58us;64us;65us;66us;67us;71us;73us;74us;75us;76us;|]
let _fsyacc_reductionSymbolCounts = [|1us;1us;2us;2us;4us;3us;1us;3us;3us;1us;3us;1us;3us;1us;2us;1us;1us;3us;2us;2us;1us;1us;|]
let _fsyacc_productionToNonTerminalTable = [|0us;1us;1us;2us;2us;2us;3us;3us;3us;4us;4us;5us;5us;6us;6us;7us;7us;7us;7us;7us;8us;9us;|]
let _fsyacc_immediateActions = [|65535us;49152us;65535us;16386us;65535us;16387us;65535us;65535us;65535us;16388us;65535us;65535us;16389us;16390us;65535us;65535us;16391us;65535us;65535us;16392us;65535us;65535us;16394us;65535us;65535us;16396us;65535us;16398us;16399us;16400us;65535us;65535us;16401us;16402us;16403us;16404us;|]
let _fsyacc_reductions ()  =    [| 
# 185 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?>  AST.Program  in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : 'gentype__startstart));
# 194 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_stmt in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 34 "Parser.fsy"
                                  [_1]
                   )
# 34 "Parser.fsy"
                 :  AST.Program ));
# 205 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_stmt in
            let _2 = parseState.GetInput(2) :?>  AST.Program  in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 35 "Parser.fsy"
                                        _1 :: _2
                   )
# 35 "Parser.fsy"
                 :  AST.Program ));
# 217 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_vname in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 37 "Parser.fsy"
                                           AST.Print(_2)
                   )
# 37 "Parser.fsy"
                 : 'gentype_stmt));
# 228 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_vname in
            let _4 = parseState.GetInput(4) :?> 'gentype_expr in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 38 "Parser.fsy"
                                                 AST.VDecl(_2,_4)
                   )
# 38 "Parser.fsy"
                 : 'gentype_stmt));
# 240 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_vname in
            let _3 = parseState.GetInput(3) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 39 "Parser.fsy"
                                                      AST.PrintToDot(_2,_3)
                   )
# 39 "Parser.fsy"
                 : 'gentype_stmt));
# 252 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_regexp_full in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 41 "Parser.fsy"
                                        AST.RegExp(_1)
                   )
# 41 "Parser.fsy"
                 : 'gentype_expr));
# 263 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> string in
            let _3 = parseState.GetInput(3) :?> 'gentype_regexp_full in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 42 "Parser.fsy"
                                                        AST.FindAll(_2,_3)
                   )
# 42 "Parser.fsy"
                 : 'gentype_expr));
# 275 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> string in
            let _3 = parseState.GetInput(3) :?> 'gentype_regexp_full in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "Parser.fsy"
                                                             AST.IsAcceptable(_2,_3)
                   )
# 43 "Parser.fsy"
                 : 'gentype_expr));
# 287 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_regexp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 45 "Parser.fsy"
                                          _1
                   )
# 45 "Parser.fsy"
                 : 'gentype_regexp_full));
# 298 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_regexp in
            let _3 = parseState.GetInput(3) :?> 'gentype_regexp_full in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 46 "Parser.fsy"
                                                          AST.Intersect(_1,_3)
                   )
# 46 "Parser.fsy"
                 : 'gentype_regexp_full));
# 310 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "Parser.fsy"
                                  _1
                   )
# 48 "Parser.fsy"
                 : 'gentype_regexp));
# 321 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq in
            let _3 = parseState.GetInput(3) :?> 'gentype_regexp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "Parser.fsy"
                                                        AST.Alt(_1,_3)
                   )
# 48 "Parser.fsy"
                 : 'gentype_regexp));
# 333 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq_elem in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 50 "Parser.fsy"
                                    _1
                   )
# 50 "Parser.fsy"
                 : 'gentype_seq));
# 344 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq_elem in
            let _2 = parseState.GetInput(2) :?> 'gentype_seq in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 50 "Parser.fsy"
                                                        AST.Seq(_1,_2)
                   )
# 50 "Parser.fsy"
                 : 'gentype_seq));
# 356 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> char in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "Parser.fsy"
                                    AST.RSmb(_1)
                   )
# 52 "Parser.fsy"
                 : 'gentype_seq_elem));
# 367 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_vname in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 53 "Parser.fsy"
                                      AST.RVar(_1)
                   )
# 53 "Parser.fsy"
                 : 'gentype_seq_elem));
# 378 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_regexp_full in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 54 "Parser.fsy"
                                                    _2
                   )
# 54 "Parser.fsy"
                 : 'gentype_seq_elem));
# 389 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq_elem in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 55 "Parser.fsy"
                                              AST.Star(_1)
                   )
# 55 "Parser.fsy"
                 : 'gentype_seq_elem));
# 400 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_seq_elem in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 56 "Parser.fsy"
                                             AST.Opt(_1)
                   )
# 56 "Parser.fsy"
                 : 'gentype_seq_elem));
# 411 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 58 "Parser.fsy"
                                   AST.Var(_1)
                   )
# 58 "Parser.fsy"
                 : 'gentype_vname));
# 422 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 60 "Parser.fsy"
                               1
                   )
# 60 "Parser.fsy"
                 : 'gentype_eof));
|]
# 433 "Parser.fs"
let tables : FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 19;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = tables.Interpret(lexer, lexbuf, startState)
let start lexer lexbuf :  AST.Program  =
    engine lexer lexbuf 0 :?> _