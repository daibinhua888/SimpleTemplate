grammar Template;


/*
 * Parser Rules
 */

compileUnit
	:	parse
	;




	
NEWLINE:'\r'? '\n';

NUMBER: '0'..'9';
CHAR: 'a'..'z'|'A'..'Z';
UNDERLINE: '_';

SPACE:' ';
DOT:'.';

V_START:'@{';
V_END:'}';

parse
	:expression*
	;

expression
	: stringtext
	| simple_variable
	| complex_variable
	| repeater_stmt
	;


repeater_stmt
	: repeater_stmt_begin expression* repeater_stmt_end
	;

repeater_stmt_begin
	: V_START 'repeat' SPACE repeater_stmt_count V_END
	;

repeater_stmt_end
	: V_START 'end repeat' V_END
	;

repeater_stmt_count
	: digital
	| simple_variable_inner
	| complex_variable_inner
	;

	
newlines
	:NEWLINE NEWLINE*
	;

stringtext
	: placeholderChar (placeholderChar)*
	| newlines
	;
	
placeholderChar
	: CHAR
	| ':'
	| SPACE
	| NUMBER
	| DOT
	| '\''
	| '"'
	| '<'
	| '>'
	| '_'
	| '+'
	| '-'
	| '*'
	| '/'
	;
	

simple_variable
	:V_START simple_variable_inner V_END
	;

complex_variable
	:V_START complex_variable_inner V_END
	;


simple_variable_inner
	:identity
	;

complex_variable_inner
	:identity DOT identity
	;

identity
	:(UNDERLINE|CHAR) (UNDERLINE|CHAR|NUMBER)*
	;

digital
	: NUMBER NUMBER*
	;
	
	