Þ
XC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Application\CursoDto.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Application *
{ 
public 

class 
CursoDto 
{ 
public 
CursoDto 
( 
Guid 
idCurso 
, 
string		 
nome		 
,		 
string

 
	descricao

 
,

 
Guid 
idProfessor 
, 
ProfessorDto 
professorDto %
,% &
DateTime 
dataCriacao  
,  !
DateTime 
dataAtualizacao $
)$ %
{ 	
IdCurso 
= 
idCurso 
; 
Nome 
= 
nome 
; 
	Descricao 
= 
	descricao !
;! "
IdProfessor 
= 
idProfessor %
;% &
ProfessorDto 
= 
professorDto '
;' (
DataCriacao 
= 
dataCriacao %
;% &
DataAtualizacao 
= 
dataAtualizacao -
;- .
} 	
public 
Guid 
IdCurso 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
public 
Guid 
IdProfessor 
{  !
get" %
;% &
set' *
;* +
}, -
public!! 
ProfessorDto!! 
ProfessorDto!! (
{!!) *
get!!+ .
;!!. /
set!!0 3
;!!3 4
}!!5 6
public## 
DateTime## 
DataCriacao## #
{##$ %
get##& )
;##) *
private##+ 2
set##3 6
;##6 7
}##8 9
public%% 
DateTime%% 
DataAtualizacao%% '
{%%( )
get%%* -
;%%- .
private%%/ 6
set%%7 :
;%%: ;
}%%< =
public'' 
static'' 
implicit'' 
operator'' '
Curso''( -
(''- .
CursoDto''. 6
cursoDto''7 ?
)''? @
=>''A C
new(( 
((( 
cursoDto)) 
.)) 
DataAtualizacao)) (
,))( )
cursoDto** 
.** 
Nome** 
,** 
cursoDto++ 
.++ 
	Descricao++ "
)++" #
;++# $
public-- 
static-- 
implicit-- 
operator-- '
CursoDto--( 0
(--0 1
Curso--1 6
curso--7 <
)--< =
=>--> @
new.. 
(.. 
curso.. 
... 
Id.. 
,.. 
curso// 
.// 
Nome// 
,// 
curso00 
.00 
	Descricao00 
,00  
curso11 
.11 
IdProfessor11 !
,11! "
professorDto22 
:22 
curso22 #
.22# $
	Professor22$ -
,22- .
curso33 
.33 
DataCriacao33 !
,33! "
curso44 
.44 
DataAtualizacao44 %
)44% &
;44& '
}55 
}66 ×	
oC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Application\Interfaces\IProfessorAppService.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Application *
.* +

Interfaces+ 5
{ 
public 

	interface  
IProfessorAppService )
{ 
ProfessorDto 
AdicionarProcessor '
(' (
ProfessorDto( 4
professorDto5 A
)A B
;B C
IEnumerable 
< 
ProfessorDto  
>  !
ListarProfessores" 3
(3 4
)4 5
;5 6
ProfessorDto		 
ObterProfessor		 #
(		# $
Guid		$ (
IdProfessor		) 4
)		4 5
;		5 6
ProfessorDto 
AtualizarProfessor '
(' (
Guid( ,
IdProfessor- 8
,8 9
ProfessorDto: F
ProfessorDtoG S
)S T
;T U
void 
DeletarProfessor 
( 
Guid "
IdProfessor# .
). /
;/ 0
} 
} ‹
\C:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Application\ProfessorDto.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Application *
{ 
public 

class 
ProfessorDto 
{ 
public 
ProfessorDto 
( 
Guid 
idProfessor 
, 
string		 
nome		 
,		 
decimal

 
salario

 
,

 
DateTime 
dataCriacao  
,  !
DateTime 
dataAtualizacao $
)$ %
{ 	
IdProfessor 
= 
idProfessor %
;% &
Nome 
= 
nome 
; 
Salario 
= 
salario 
; 
DataCriacao 
= 
dataCriacao %
;% &
DataAtualizacao 
= 
dataAtualizacao -
;- .
} 	
public 
Guid 
IdProfessor 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
decimal 
Salario 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
DateTime 
DataCriacao #
{$ %
get& )
;) *
private+ 2
set3 6
;6 7
}8 9
public 
DateTime 
DataAtualizacao '
{( )
get* -
;- .
private/ 6
set7 :
;: ;
}< =
public 
static 
implicit 
operator '
	Professor( 1
(1 2
ProfessorDto2 >
professorDto? K
)K L
=>M O
new   
(   
professorDto   
.   
DataAtualizacao   ,
,  , -
professorDto!! 
.!! 
Nome!! !
,!!! "
professorDto"" 
."" 
Salario"" $
)""$ %
;""% &
public$$ 
static$$ 
implicit$$ 
operator$$ '
ProfessorDto$$( 4
($$4 5
	Professor$$5 >
	professor$$? H
)$$H I
=>$$J L
new%% 
(%% 
	professor%% 
.%% 
Id%% 
,%% 
	professor&& 
.&& 
Nome&& 
,&& 
	professor'' 
.'' 
Salario'' !
,''! "
	professor(( 
.(( 
DataCriacao(( %
,((% &
	professor)) 
.)) 
DataAtualizacao)) )
)))) *
;))* +
}** 
}++ ø
lC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Application\Services\ProfessorAppService.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
ProfessorAppService $
:% & 
IProfessorAppService' ;
{ 
public 
ProfessorDto 
AdicionarProcessor .
(. /
ProfessorDto/ ;
	professor< E
)E F
{ 	
throw		 
new		 #
NotImplementedException		 -
(		- .
)		. /
;		/ 0
}

 	
public 
ProfessorDto 
AtualizarProfessor .
(. /
Guid/ 3
IdProfessor4 ?
,? @
ProfessorDtoA M
ProfessorDtoN Z
)Z [
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
void 
DeletarProfessor $
($ %
Guid% )
IdProfessor* 5
)5 6
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
IEnumerable 
< 
ProfessorDto '
>' (
ListarProfessores) :
(: ;
); <
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
ProfessorDto 
ObterProfessor *
(* +
Guid+ /
IdProfessor0 ;
); <
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
} 
}   