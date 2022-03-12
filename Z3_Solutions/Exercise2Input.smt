(declare-const D Int)
(declare-const E Int)
(declare-const M Int)
(declare-const N Int)
(declare-const O Int)
(declare-const R Int)
(declare-const S Int)
(declare-const Y Int)

(declare-const send Int)
(declare-const more Int)
(declare-const money Int)

	(assert (and 
		(>= D 0) (<= D 9) (>= E 0) (<= E 9) 
		(>= M 0) (<= M 9) (>= N 0) (<= N 9) 
		(>= O 0) (<= O 9) (>= R 0) (<= R 9)
		(>= S 0) (<= S 9) (>= Y 0) (<= Y 9)  
	))

(assert(distinct D E M N O R S Y))

(assert(= send (+ (* 1000 S) (* 100 E) (* 10 N) D )))
(assert(= more (+ (* 1000 M) (* 100 O) (* 10 R) E )))
(assert(= money (+ (* 10000 M) (* 1000 O) (* 100 N) (* 10 E) Y )))
(assert(= money (+ send more)))

(check-sat)
(get-model)
(get-value (send more money))
