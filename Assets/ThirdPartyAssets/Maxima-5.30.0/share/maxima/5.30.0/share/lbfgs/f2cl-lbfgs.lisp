(load "/home/robert/lisp/f2cl0.l")
(load "/home/robert/lisp/f2cl1.l")
(load "/home/robert/lisp/f2cl2.l")
(load "/home/robert/lisp/f2cl3.l")
(load "/home/robert/lisp/f2cl4.l")
(load "/home/robert/lisp/f2cl5.l")
(load "/home/robert/lisp/f2cl6.l")
(load "/home/robert/lisp/f2cl7.l")
(load "/home/robert/lisp/f2cl8.l")
(load "/home/robert/lisp/macros.l")
(f2cl::f2cl "./lbfgs.f" :declare-common t)
(load "./lbfgs.lisp")
(f2cl::f2cl "./sdrive.f")