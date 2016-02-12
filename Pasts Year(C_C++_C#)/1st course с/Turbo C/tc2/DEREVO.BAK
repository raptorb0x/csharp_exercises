struct drv{
int n;
struct drv *pr;
struct drv *lev;} krn;

struct drv * dform(struct drv *krn,int m){
if (!krn){
krn=(struct drv *)malloc(sizeof(struct drv));
krn->n=m;
krn->lev=krn->pr=0;}
else if(krn->n<m)
krn->pr=dform(krn->pr,m);
else krn->lev=dform(krn->lev,m) ;
return krn;}

dprintf(struct drv *krn)
{
if (krn) dprintf (krn->lev);
printf("%d",krn->n);
dprintf(krn->pr);}

main(){
struct drv *derevo=0;
int m,i;
for(i=0;i<10;i++){
scanf("%d",&m);
derevo=dform(derevo,m);};
dprintf(derevo);
}
