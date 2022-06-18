Í

^C:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Entities\BaseEntity.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Domain %
.% &
Entities& .
{ 
public 

class 

BaseEntity 
{ 
	protected 

BaseEntity 
( 
DateTime 
dataAtualizacao $
)$ %
{ 	
Id 
= 
Guid 
. 
NewGuid 
( 
)  
;  !
DataCriacao		 
=		 
DateTime		 "
.		" #
Now		# &
;		& '
DataAtualizacao

 
=

 
dataAtualizacao

 -
;

- .
} 	
public 
Guid 
Id 
{ 
get 
; 
set !
;! "
}# $
public 
DateTime $
DataCriacao% 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
public 
DateTime 
DataAtualizacao '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} Œ
YC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Entities\Curso.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Domain %
.% &
Entities& .
{ 
public 

class 
Curso 
: 

BaseEntity #
{ 
public 
Curso 
( 
DateTime 
dataAtualizacao $
,$ %
string 
nome 
, 
string 
	descricao 
) 
: 
base  $
($ %
dataAtualizacao% 4
)4 5
{		 	
Nome

 
=

 
nome

 
;

 
	Descricao 
= 
	descricao !
;! "
} 	
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
public 
Guid 
IdProfessor 
{  !
get" %
;% &
set' *
;* +
}, -
public 
	Professor 
	Professor "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} Õ	
]C:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Entities\Professor.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Domain %
.% &
Entities& .
{ 
public 

class 
	Professor 
: 

BaseEntity '
{ 
public 
	Professor 
( 
DateTime 
dataAtualizacao $
,$ %
string 
nome 
, 
decimal 
salario 
)		 
:

 
base

 
(

 
dataAtualizacao

 #
)

# $
{ 	
Nome 
= 
nome 
; 
Salario 
= 
salario 
; 
} 	
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
Decimal 
Salario 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ¯	
gC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Interfaces\IProfessorService.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Domain %
.% &

Interfaces& 0
{ 
public 

	interface 
IProfessorService &
{ 
	Professor 
AdicionarProcessor $
($ %
	Professor% .
	professor/ 8
)8 9
;9 :
IEnumerable		 
<		 
	Professor		 
>		 
ListarProfessores		 0
(		0 1
)		1 2
;		2 3
	Professor 
ObterProfessor  
(  !
Guid! %
IdProfessor& 1
)1 2
;2 3
	Professor 
AtualizarProfessor $
($ %
Guid% )
IdProfessor* 5
,5 6
	Professor7 @
	ProfessorA J
)J K
;K L
void 
DeletarProfessor 
( 
Guid "
IdProfessor# .
). /
;/ 0
} 
} ®
lC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Repositories\IProfessorRepository.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Domain %
.% &
Repositories& 2
{ 
public 

	interface  
IProfessorRepository )
{ 
} 
} Û
gC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Domain\Services\ProfessorAppService.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
ProfessorService !
:" #
IProfessorService$ 5
{ 
public 
	Professor 
AdicionarProcessor +
(+ ,
	Professor, 5
	professor6 ?
)? @
{		 	
throw

 
new

 #
NotImplementedException

 -
(

- .
)

. /
;

/ 0
} 	
public 
	Professor 
AtualizarProfessor +
(+ ,
Guid, 0
IdProfessor1 <
,< =
	Professor> G
ProfessorDtoH T
)T U
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
void 
DeletarProfessor $
($ %
Guid% )
IdProfessor* 5
)5 6
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
IEnumerable 
< 
	Professor $
>$ %
ListarProfessores& 7
(7 8
)8 9
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
	Professor 
ObterProfessor '
(' (
Guid( ,
IdProfessor- 8
)8 9
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
}   
}!! 