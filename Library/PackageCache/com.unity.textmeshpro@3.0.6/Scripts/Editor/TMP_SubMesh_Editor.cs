" "+_.C("kc-A")+'" data-target="undo">';return(0,_.D)(a+"Undo</button>")});var fNg=function(a,b){_.M1.call(this,_.elb,a);this.parentId=b||null};_.S(fNg,_.M1);var gNg=function(a,b){_.U1.call(this,a,b,151,!1);this.Aj=_.BM(a);this.V=new GLg(a);this.W=(new _.Ry(a)).BL();this.Mb=_.vw(a)};_.S(gNg,_.U1);
gNg.prototype.G5=function(){var a=this,b=this.Ob();return Promise.resolve(_.AKg(this,b.H,"remove_count",this.Aj.cj(_.Je))).then(function(){return a.W?ILg(a.V,a.ki.RF):Promise.resolve()}).then(function(){a.Pt();return _.nyd(a,function(){return a.yk()},function(){return _.wu(new lMg(a.Ob().H),a.Fa())})}).then(function(c){var d=b.H,e=_.Ng(_.Og,a.Mb.Yd());e&&(e=e.kk())&&-1!==d.indexOf(e)&&(d={view:_.Eg.tl},_.Ag(a.Fa(),d,_.fA,a.O.bm()),a.Mb.navigate(d));return c})};
gNg.prototype.gz=function(){return new _.kw(dNg,{ki:{Mf:this.ki.Mf,Sf:this.ki.Sf,I2:this.ki.I2,J2:this.ki.J2,Fi:this.ki.Fi}})};gNg.prototype.Rl=function(){return new _.kw(eNg,{ki:{Mf:this.ki.Mf,Sf:this.ki.Sf,yja:this.ki.yja,I2:this.ki.I2,J2:this.ki.J2,Fi:this.ki.Fi,GS:this.ki.GS,HS:this.ki.HS}})};gNg.prototype.yk=function(){return _.wu(new fNg(this.Ob().H),this.Fa())};var hNg=function(a,b,c){_.M1.call(this,_.Ykb,a);this.H=b;this.parentId=c};_.S(hNg,_.M1);var iNg=function(a,b){_.U1.call(this,a,b,138,!1);this.Aj=_.BM(a);this.V=new GLg(a);this.W=(new _.Ry(a)).BL();this.Mb=a.get(_.Mg);this.Vz=a.get(_.Xs)};_.S(iNg,_.U1);_.h=iNg.prototype;
_.h.G5=function(){var a=this;return Promise.resolve(_.AKg(this,this.Ob().H,"remove_from_folder_count",this.Aj.cj(_.Je)).addCallback(function(){return a.W?_.Tl(ILg(a.V,a.ki.RF)):_.Gh()}).addCallback(function(){a.Pt()}).addCallback(function(){var b=a.Vz.ZZ.get();if(b&&a.Ob().H.includes(b.getId())){var c=_.P4c(b).get();b=_.Ijb(b).get();!c&&0<b.length&&(c=b[0]);c&&(c===a.Ec.Oo().rb()?(c={view:_.Eg.tl},b=_.fA):(c={view:_.Eg.Ym,path:[c]},b=_.Fob),_.Ag(a.Fa(),c,b,a.O.bm()),a.Mb.navigate(c))}}).addCallback(function(){return _.nyd(a,
function(){return a.yk()},function(){return a.Gu()})}))};_.h.gz=function(){return new _.kw(dNg,{ki:this.ki})};_.h.Rl=function(){return new _.kw(eNg,{ki:this.ki})};_.h.Gu=function(){var a=this.Ob();return _.wu(new hNg(a.H,a.O,a.parentId),this.Fa())};_.h.yk=function(){var a=this.Ob();return _.wu(new fNg(a.H,a.parentId),this.Fa())};var jNg=function(a){var b=a.parent;a="Removing "+_.dr(_.X(a.title))+" from "+_.dr(_.X(b));return(0,_.D)("<span>"+a+"</span>")},kNg=function(a){var b=a.parent,c=a.title;a='<div class="'+_.C("la-r")+'">';b="Removed "+_.dr(_.X(c))+" from "+_.dr(_.X(b));return(0,_.D)(a+b+"</div>")};var lNg