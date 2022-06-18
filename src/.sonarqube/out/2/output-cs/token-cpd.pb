ô
}C:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Infra.Database\Configurations\BaseEntityTypeConfiguration.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Infra $
.$ %
Database% -
.- .
Configurations. <
{ 
public 

class '
BaseEntityTypeConfiguration ,
:- .$
IEntityTypeConfiguration/ G
<G H

BaseEntityH R
>R S
{ 
public		 
void		 
	Configure		 
(		 
EntityTypeBuilder		 /
<		/ 0

BaseEntity		0 :
>		: ;
builder		< C
)		C D
{

 	
builder 
. 
HasKey 
( 
x 
=> 
x 
. 
Id !
)! "
;" #
builder 
. 
Property 
( 
x 
=> 
x  
.  !
DataCriacao! ,
), -
. 
HasColumnName 
( 
$str ,
), -
. 
HasColumnType 
( 
$str )
)) *
;* +
builder 
. 
Property 
( 
x 
=> 
x  
.  !
DataAtualizacao! 0
)0 1
. 
HasColumnName 
( 
$str 0
)0 1
;1 2
} 	
} 
} ´
‚C:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Infra.Database\Configurations\ProfessorEntityTypeConfiguration.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Infra $
.$ %
Database% -
.- .
Configurations. <
{ 
public 

class ,
 ProfessorEntityTypeConfiguration 1
:2 3$
IEntityTypeConfiguration4 L
<L M
	ProfessorM V
>V W
{ 
public		 
void		 
	Configure		 
(		 
EntityTypeBuilder		 /
<		/ 0
	Professor		0 9
>		9 :
builder		; B
)		B C
{

 	
builder 
. 
ToTable 
( 
$str *
)* +
;+ ,
builder 
. 
Property 
( 
x 
=> 
x  
.  !
Nome! %
)% &
. 
HasColumnName 
( 
$str .
). /
;/ 0
builder 
. 
Property 
( 
x 
=> 
x  
.  !
Salario! (
)( )
. 
HasColumnName 
( 
$str 1
)1 2
. 
HasColumnType 
( 
$str -
)- .
;. /
} 	
} 
} Ã
zC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Infra.Database\Migrations\20220618121749_InitialCreate.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Infra $
.$ %
Database% -
.- .

Migrations. 8
{ 
public 

partial 
class 
InitialCreate &
:' (
	Migration) 2
{		 
	protected

 
override

 
void

 
Up

  "
(

" #
MigrationBuilder

# 3
migrationBuilder

4 D
)

D E
{ 	
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str $
,$ %
columns 
: 
table 
=> !
new" %
{ 
Id 
= 
table 
. 
Column %
<% &
Guid& *
>* +
(+ ,
type, 0
:0 1
$str2 D
,D E
nullableF N
:N O
falseP U
)U V
,V W
NomeProfessor !
=" #
table$ )
.) *
Column* 0
<0 1
string1 7
>7 8
(8 9
type9 =
:= >
$str? N
,N O
nullableP X
:X Y
falseZ _
)_ `
,` a
SalarioProfessor $
=% &
table' ,
., -
Column- 3
<3 4
decimal4 ;
>; <
(< =
type= A
:A B
$strC Q
,Q R
nullableS [
:[ \
false] b
)b c
,c d
DataCriacao 
=  !
table" '
.' (
Column( .
<. /
DateTime/ 7
>7 8
(8 9
type9 =
:= >
$str? J
,J K
nullableL T
:T U
falseV [
)[ \
,\ ]
DataAtualizacao #
=$ %
table& +
.+ ,
Column, 2
<2 3
DateTime3 ;
>; <
(< =
type= A
:A B
$strC N
,N O
nullableP X
:X Y
falseZ _
)_ `
} 
, 
constraints 
: 
table "
=># %
{ 
table 
. 

PrimaryKey $
($ %
$str% 6
,6 7
x8 9
=>: <
x= >
.> ?
Id? A
)A B
;B C
} 
) 
; 
} 	
	protected 
override 
void 
Down  $
($ %
MigrationBuilder% 5
migrationBuilder6 F
)F G
{ 	
migrationBuilder 
. 
	DropTable &
(& '
name 
: 
$str $
)$ %
;% &
}   	
}!! 
}"" ‘
aC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Infra.Database\ProjetoContext.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Infra $
.$ %
Database% -
{ 
public 

class 
ProjetoContext 
:  !
	DbContext" +
{ 
public 
DbSet 
< 
	Professor 
> 
Professores  +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
	protected 
override 
void 
OnConfiguring  -
(- .#
DbContextOptionsBuilder. E
optionsBuilderF T
)T U
{ 	
optionsBuilder 
. 
UseSqlServer '
(' (
$str	( ü
)
ü ý
;
ý þ
} 	
	protected 
override 
void 
OnModelCreating  /
(/ 0
ModelBuilder0 <
modelBuilder= I
)I J
{ 	
modelBuilder 
. 
ApplyConfiguration +
(+ ,
new, /,
 ProfessorEntityTypeConfiguration0 P
(P Q
)Q R
)R S
;S T
base 
. 
OnModelCreating  
(  !
modelBuilder! -
)- .
;. /
} 	
}   
}!! Ô
sC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Infra.Database\Repositories\ProfessorRepository.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Infra $
.$ %
Database% -
.- .
Repositories. :
{ 
public 

class 
ProfessorRepository $
{ 
} 
} 