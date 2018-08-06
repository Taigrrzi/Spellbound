lexer grammar SpellLexer;

ID : ([A-Z] | [a-z])+ ; // match lower-case identifiers
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines