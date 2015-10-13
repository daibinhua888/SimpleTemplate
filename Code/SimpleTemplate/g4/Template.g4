grammar Template;


/*
 * Parser Rules
 */

compileUnit
	:	parse
	;






WS
	:	[ \t]+ -> skip
	;	
	
NEWLINE:'\r'? '\n';

NUMBER: '0'..'9';
CHAR: 'a'..'z'|'A'..'Z';
UNDERLINE: '_';

SPACE:' ';
DOT:'.';

V_START:'@{';
V_END:'}';

KEY_IF:'if';
KEY_ELSE:'else';
KEY_ENDIF:'/if';

OP_EQUAL:'=';
OP_GT:'>';
OP_EGT:'>=';
OP_LT:'<';
OP_ELT:'<=';

parse
	:expression*
	;

expression
	: stringtext
	| simple_variable
	| complex_variable
	| repeater_stmt
	| if_stmt
	;


repeater_stmt
	: repeater_stmt_begin expression* repeater_stmt_end
	;

repeater_stmt_begin
	: V_START 'repeat' repeater_stmt_count V_END
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
	
if_stmt
	:if_stmt_conditions_block if_stmt_else_block? if_stmt_end_if_block 
	;

if_stmt_conditions_block
	: V_START KEY_IF if_stmt_conditions V_END if_stmt_conditions_body
	;

if_stmt_conditions_body
	: parse
	;

if_stmt_conditions
	: if_stmt_condition
	;

if_stmt_condition
	:left_op op right_op
	;

if_stmt_else_block
	:V_START KEY_ELSE V_END if_stmt_else_body
	;
	
if_stmt_else_body
	: parse
	;


if_stmt_end_if_block
	:V_START KEY_ENDIF V_END
	;

left_op
	: digital
	| simple_variable_inner
	| complex_variable_inner
	;

right_op
	: digital
	| simple_variable_inner
	| complex_variable_inner
	;

op
	:OP_EQUAL
	|OP_GT
	|OP_EGT
	|OP_LT
	|OP_ELT
	;
	
