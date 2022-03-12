(declare-fun B (Int Int) Int)
; timepoint at which the required end-state is reached
(declare-const N Int)

(define-fun Total((t Int)) Int
	(+
		(B t 1)
		(B t 2)
		(B t 3)
	)
)

(assert (and
; begin-state:
(= (B 0 1) 321)
(= (B 0 2) 0)
(= (B 0 3) 0)

; wanted end-state:
(= (B N 1) 0)
(= (B N 2) 0)
(= (B N 3) 321)


;the value of a stick is never negative, and at most the capacity of all plates together
(forall ((t Int)(pl Int))
	(implies (<= 0 t N)
		(<= 0 (B t pl) 321)
	)
)

;total amount of water remains constant
(forall ((t Int))
	(implies (<= 0 t)
		(= (Total t)(Total (+ t 1)))
	)
)

;on each step, one jug remains unaltered, one of the others becomes either full or empty
(forall ((t Int))
	(implies 
		(<= 0 t N)  ; restriction to a finite situation is necessary, because of the 'exists' clause below
		(exists ((pl1 Int) (pl2 Int) (pl3 Int))    
			(and
				(distinct pl1 pl2 pl3)
				(<= 1 pl1 3)
				(<= 1 pl2 3)
				(<= 1 pl3 3)

				(= (B t pl1)(B (+ t 1) pl1))  ; one stick remains the same 
				(distinct (B t pl2)(B (+ t 1) pl2))  ; the other two sticks change plates
				(distinct (B t pl3)(B (+ t 1) pl3))
				
				(or   ;removing plates from one stick and adding the plate to another stick.
					(and (= (B (+ t 1) pl2) (- (B t pl2) 1) ) (or (= (B t pl2) 1) (= (B t pl2) 21) (= (B t pl2) 321))
						 (= (B (+ t 1) pl3) (+ (B t pl3) 1) ) (or (= (B t pl3) 0) (= (B t pl3) 20) (= (B t pl3) 320) (= (B t pl3) 300)))

					(and (= (B (+ t 1) pl2) (- (B t pl2) 20) ) (or (= (B t pl2) 20) (= (B t pl2) 320 ) )
						 (= (B (+ t 1) pl3) (+ (B t pl3) 20) ) (or (= (B t pl3) 0) (= (B t pl3) 300 ) ) )
						 
					(and (= (B (+ t 1) pl2) (- (B t pl2) 300) ) (= (B t pl2) 300)
						 (= (B (+ t 1) pl3) (+ (B t pl3) 300) ) (= (B t pl3) 0 ))
				)
			)
		)
	)
) 
;restrict the search to at most 10 steps
(<= 0 N 10)

))
(check-sat)
(get-value (
   N
  (B 0 1)
  (B 0 2)
  (B 0 3)
  (B 1 1)
  (B 1 2)
  (B 1 3)
  (B 2 1)
  (B 2 2)
  (B 2 3)

  (B 3 1)
  (B 3 2)
  (B 3 3)

  (B 4 1)
  (B 4 2)
  (B 4 3)

  (B 5 1)
  (B 5 2)
  (B 5 3)

  (B 6 1)
  (B 6 2)
  (B 6 3)

  (B 7 1)
  (B 7 2)
  (B 7 3)

  (B 8 1)
  (B 8 2)
  (B 8 3)

  (B 9 1)
  (B 9 2)
  (B 9 3)

  (B 10 1)
  (B 10 2)
  (B 10 3)

))
