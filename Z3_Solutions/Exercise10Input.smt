; PrimeNumber puzzle
(declare-const a Int)
(declare-const b Int)
(declare-const c Int)
(declare-const d Int)
(declare-const e Int)
(declare-const f Int)
(declare-const g Int)
(declare-fun C (Int Int) Int)
(declare-const N Int)

(define-fun addedNumber((addedNum Int) (prevAddedNum Int)) Bool
	(= (+
		(ite (and (= prevAddedNum a ) (or (= addedNum b) (= addedNum e) (= addedNum g) )) 1 0)
    (ite (and (= prevAddedNum b ) (or (= addedNum c) (= addedNum e) (= addedNum a) )) 1 0)
    (ite (and (= prevAddedNum c ) (or (= addedNum b) (= addedNum e) (= addedNum d) )) 1 0)
    (ite (and (= prevAddedNum d ) (or (= addedNum c) (= addedNum e) (= addedNum f) )) 1 0)
    (ite (and (= prevAddedNum f ) (or (= addedNum d) (= addedNum e) (= addedNum g) )) 1 0)
    (ite (and (= prevAddedNum g ) (or (= addedNum a) (= addedNum e) (= addedNum f) )) 1 0)
    (ite (and (= prevAddedNum e ) (not (= addedNum e) )) 1 0)
	) 1)
)

(define-fun IsPrimeNumber((sum Int)) Bool
  (not(exists ((y Int) (z Int))
    (and
        (< 1 y sum) (< 1 z sum)
        (= (* y z) sum)
    )
  ))
)


(assert (and
;define the value of the 'circles'
(= a 3) (= b 4) (= c 8) (= d 10)
(= e 2) (= f 6) (= g 20)

;define the 'START'/ first step
(= (C 0 1) a)
(= (C 0 2) 3)

;define the 'FINISH'/ last step
(= (C N 1) g)
(= (C N 2) 79)

(forall ((t Int) (z Int) (y Int))
	(implies 
		(<= 1 t N)  
			(and
        (= (C t 2) (+ (C t 1) (C (- t 1) 2)) ) ;The sum of the added num and the prevoius sum
				(distinct (C t 2)(C (- t 1) 2))        ;The two sums are distinct
        (> (C t 2) (C (- t 1) 2))              ;The sum is larger than the sum form the previous step
        (addedNumber (C t 1) (C (- t 1) 1))    ;The added number is next to the prevoiusly added number
        (IsPrimeNumber (C t 2))                ;Confirm that there do not exist two integers, which product equals the sum
			)
	)
) 

;restrict the search to at most 20 steps
(<= 0 N 20)

))
(check-sat)
(get-value (
   N
  (C 0 1)
  (C 0 2)

  (C 1 1)
  (C 1 2)
 
  (C 2 1)
  (C 2 2)

  (C 3 1)
  (C 3 2)

  (C 4 1)
  (C 4 2)

  (C 5 1)
  (C 5 2)

  (C 6 1)
  (C 6 2)

  (C 7 1)
  (C 7 2)

  (C 8 1)
  (C 8 2)

  (C 9 1)
  (C 9 2)

  (C 10 1)
  (C 10 2)
))

