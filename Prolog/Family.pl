child(X,Y) :- parent(Y,X).
spouse(X,Y) :- child(P,X), child(P,Y).
husband(X,Y) :- male(X), spouse(X,Y).
wife(X,Y) :- female(X), spouse(X,Y).
son(X,Y) :- male(X), child(X,Y).
daughter(X,Y) :- female(X), child(X,Y).
mother(X,Y) :- female(X), parent(X,Y).
father(X,Y) :- male(X), parent(X,Y).
sibling(X,Y) :- parent(P,X), parent(P,Y), X\=Y.
brother(X,Y) :- male(X), sibling(X,Y).
sister(X,Y) :- female(X), sibling(X,Y).
grandmother(X,Y) :- mother(X,P), parent(P,Y).
grandfather(X,Y) :- father(X,P), parent(P,Y).
grandson(X,Y) :- son(X,P), parent(Y,P).
granddaughter(X,Y) :- daughter(X,P), parent(Y,P).
aunt(X,Y) :- sister(X,P), parent(P,Y).
aunt(X,Y) :- wife(X,P), sibling(P,Q), parent(Q,Y).
uncle(X,Y) :- brother(X,P), parent(P,Y).
uncle(X,Y) :- husband(X,P), sibling(P,Q), parent(Q,Y).
niece(X,Y) :- daughter(X,P), sibling(P,Y).
niece(X,Y) :- daughter(X,P), sibling(P,Q), spouse(Q,Y).
nephew(X,Y) :- son(X,P), sibling(P,Y).
nephew(X,Y) :- son(X,P), sibling(P,Q), spouse(Q,Y).
cousin(X,Y) :- parent(P,X), sibling(P,Q), parent(Q,Y).

male(javed).
male(sheraz).
male(rehan).
male(hamza).
male(junaid).
male(ali).
male(danish).
male(faraz).
male(fazal).

female(hafsa).
female(rabia).
female(ramisha).
female(maria).
female(iqra).
female(marium).
female(urooj).
female(fatima).
female(farheen).
female(hira).
female(annie).

parent(ali,javed).
parent(ali,sheraz).
parent(ali,hafsa).
parent(faraz,hamza).
parent(fazal,rehan).
parent(fazal,rabia).
parent(fazal,ramisha).
parent(fazal,maria).
parent(fazal,iqra).

parent(hira,javed).
parent(hira,sheraz).
parent(hira,hafsa).
parent(annie,fatima).
parent(annie,farheen).
