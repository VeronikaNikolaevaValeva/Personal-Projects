; Marble puzzle
(declare-fun M (Int) Int)
(declare-fun O (Int) Int)
(declare-const N Int)

;Doubles the previous value of marbles
(define-fun DoubleTheMarbles((t Int)) Bool
	(and 
    (= (M t) (* 2 (M (- t 1))) )
    (= (O t) 2)
  )
)

;Increments by 7 the previous value of the marbles
(define-fun IncrementBySeven((t Int)) Bool
	(and 
    (= (M t) (+ 7 (M (- t 1))) )
    (= (O t) 7)
  )
)

;Decreases by 5 the previous value of the marbles
(define-fun DecreasedByFive((t Int)) Bool
	(and 
    (= (M t) (- (M (- t 1)) 5) )
    (= (O t) 5)
  )
)

(assert (and
;setting the initial amount of marbles
(= (M 0) 4)
(= (O 0) 0)
;setting the desired final amount of marbles
(= (M N) 5)

;for every step of the process one of the opreations is chosen 
(forall ((t Int))
	(implies (<= 1 t N)
		(or (IncrementBySeven t) (DecreasedByFive t) (DoubleTheMarbles t))
	)
)

;restrict the steps of the process to 5
(= N 5)
))


(check-sat)
(get-value (
   N
  (M 0) (M 1) (M 2) (M 3) (M 4) (M 5)
  (O 0) (O 1) (O 2) (O 3) (O 4) (O 5)

))

