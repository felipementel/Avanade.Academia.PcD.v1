±A
iC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Api\Controllers\ProfessoresController.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Api "
." #
Controllers# .
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public		 

class		 !
ProfessoresController		 &
:		' (
ControllerBase		) 7
{

 
private 
readonly 
ILogger  
<  !!
ProfessoresController! 6
>6 7
_logger8 ?
;? @
private 
readonly  
IProfessorAppService - 
_professorAppService. B
;B C
public !
ProfessoresController $
($ %
ILogger 
< !
ProfessoresController )
>) *
logger+ 1
,1 2 
IProfessorAppService  
professorAppService! 4
)4 5
{ 	
_logger 
= 
logger 
;  
_professorAppService  
=! "
professorAppService# 6
;6 7
} 	
[ 	
HttpGet	 
] 
public 
IActionResult 
ListarProfessores .
(. /
)/ 0
{ 	
var 
items 
=  
_professorAppService ,
., -
ListarProfessores- >
(> ?
)? @
;@ A
if 
( 
items 
. 
Count 
( 
) 
> 
$num  !
)! "
return 
Ok 
( 
items 
)  
;  !
else 
return 
NotFound 
(  
)  !
;! "
}   	
["" 	
HttpGet""	 
("" 
$str"" 
)"" 
]""  
public## 
IActionResult## 
ObterProfessor## +
(##+ ,
string##, 2
IdProfessor##3 >
)##> ?
{$$ 	
try%% 
{&& 
var'' "
IdentificadorProfessor'' *
=''+ , 
ProcessarIdProcessor''- A
(''A B
IdProfessor''B M
)''M N
;''N O
var(( 
items(( 
=((  
_professorAppService(( 0
.((0 1
ObterProfessor((1 ?
(((? @
IdProfessor((@ K
:((K L"
IdentificadorProfessor((M c
)((c d
;((d e
return** 
(** 
items** 
!=**  
null**! %
)**% &
?**' (
Ok**) +
(**+ ,
items**, 1
)**1 2
:**3 4
NotFound**5 =
(**= >
)**> ?
;**? @
}++ 
catch,, 
(,,  
ApplicationException,, '
ex,,( *
),,* +
{-- 
return.. 

BadRequest.. !
(..! "
$str.." 4
+..5 6
ex..7 9
...9 :
Message..: A
)..A B
;..B C
}// 
catch00 
(00 
	Exception00 
ex00 
)00  
{11 
return22 

BadRequest22 !
(22! "
$"22" $
$str22$ 2
{222 3
ex223 5
.225 6
Message226 =
}22= >
"22> ?
)22? @
;22@ A
}33 
}44 	
[66 	
HttpPost66	 
]66 
public77 
IActionResult77  
AdicionarProfessores77 1
(771 2
[772 3
FromBody773 ;
]77; <
ProfessorDto77= I
professorDto77J V
)77V W
{88 	
var99 
professorAdicionado99 #
=99$ % 
_professorAppService99& :
.99: ;
AdicionarProcessor99; M
(99M N
professorDto99N Z
)99Z [
;99[ \
return;; 
CreatedAtAction;; "
(;;" #
nameof<< 
(<< 
ObterProfessor<< %
)<<% &
,<<& '
new== 
{== 
id== 
=== 
professorAdicionado== .
.==. /
IdProfessor==/ :
}==; <
,==< =
professorAdicionado>> #
)>># $
;>>$ %
}?? 	
[AA 	
HttpPutAA	 
]AA 
publicBB 
IActionResultBB  
AtualizarProfessoresBB 1
(BB1 2
stringCC 
IdProfessorCC 
,CC 
[DD 
FromBodyDD 
]DD 
ProfessorDtoDD #
professorDtoDD$ 0
)DD0 1
{EE 	
tryFF 
{GG 
varHH "
IdentificadorProfessorHH *
=HH+ , 
ProcessarIdProcessorHH- A
(HHA B
IdProfessorHHB M
)HHM N
;HHN O
varII 
professorAtualizadoII '
=II( ) 
_professorAppServiceII* >
.II> ?
AtualizarProfessorII? Q
(IIQ R"
IdentificadorProfessorIIR h
,IIh i
professorDtoIIj v
)IIv w
;IIw x
returnKK 
OkKK 
(KK 
$strKK <
)KK< =
;KK= >
}LL 
catchMM 
(MM  
ApplicationExceptionMM '
exMM( *
)MM* +
{NN 
returnOO 

BadRequestOO !
(OO! "
$strOO" 4
+OO5 6
exOO7 9
.OO9 :
MessageOO: A
)OOA B
;OOB C
}PP 
catchQQ 
(QQ 
	ExceptionQQ 
exQQ 
)QQ  
{RR 
returnSS 

BadRequestSS !
(SS! "
$"SS" $
$strSS$ 2
{SS2 3
exSS3 5
.SS5 6
MessageSS6 =
}SS= >
"SS> ?
)SS? @
;SS@ A
}TT 
}UU 	
[WW 	

HttpDeleteWW	 
(WW 
$strWW !
)WW! "
]WW" #
publicXX 
IActionResultXX 
DeletarProfessoresXX /
(XX/ 0
stringXX0 6
IdProfessorXX7 B
)XXB C
{YY 	
tryZZ 
{[[ 
var\\ "
IdentificadorProfessor\\ *
=\\+ , 
ProcessarIdProcessor\\- A
(\\A B
IdProfessor\\B M
)\\M N
;\\N O 
_professorAppService]] $
.]]$ %
DeletarProfessor]]% 5
(]]5 6"
IdentificadorProfessor]]6 L
)]]L M
;]]M N
return__ 
	NoContent__  
(__  !
)__! "
;__" #
}`` 
catchaa 
(aa  
ApplicationExceptionaa '
exaa( *
)aa* +
{bb 
returncc 

BadRequestcc !
(cc! "
$strcc" 4
+cc5 6
excc7 9
.cc9 :
Messagecc: A
)ccA B
;ccB C
}dd 
catchee 
(ee 
	Exceptionee 
exee 
)ee  
{ff 
returngg 

BadRequestgg !
(gg! "
$"gg" $
$strgg$ 2
{gg2 3
exgg3 5
.gg5 6
Messagegg6 =
}gg= >
"gg> ?
)gg? @
;gg@ A
}hh 
}jj 	
privatell 
Guidll  
ProcessarIdProcessorll )
(ll) *
stringll* 0
IdProfessorll1 <
)ll< =
{mm 	
Guidoo "
IdentificadorProfessoroo '
;oo' (
ifpp 
(pp 
Guidpp 
.pp 
TryParsepp 
(pp 
IdProfessorpp )
,pp) *
outpp+ ."
IdentificadorProfessorpp/ E
)ppE F
==ppG I
falseppJ O
)ppO P
throwqq 
newqq  
ApplicationExceptionqq .
(qq. /
$strqq/ M
)qqM N
;qqN O
elserr 
returnss "
IdentificadorProfessorss -
;ss- .
}tt 	
}uu 
}vv ÿ
OC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Api\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder		 
.		 
Services		 
.		 #
AddEndpointsApiExplorer		 (
(		( )
)		) *
;		* +
builder

 
.

 
Services

 
.

 
AddSwaggerGen

 
(

 
)

  
;

  !
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
if 
( 
app 
. 
Environment 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
) 
; 
} 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
UseAuthorization 
( 
) 
; 
app 
. 
MapControllers 
( 
) 
; 
app 
. 
Run 
( 
) 	
;	 
