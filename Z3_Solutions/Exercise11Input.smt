; Missionaries and Cannibals puzzle
(declare-const missionary Int)
(declare-const cannibal Int)
(declare-fun coastA (Int) Int)
(declare-fun coastB (Int) Int)
(declare-fun direction (Int) Int)
(declare-fun boat (Int) Int)
(declare-const N Int)

(define-fun Total((t Int)) Int
	(+
	(coastA t)
	(coastB t)
    (boat t)
	)
)

;The capacity of the boat is max 2 people
(define-fun BoatCapacity((t Int)) Bool
	(= (+
	(ite (= (boat t) (* 2 missionary)) 1 0)
    (ite (= (boat t) (* 2 cannibal)) 1 0)
    (ite (= (boat t) (+ cannibal missionary)) 1 0)
    (ite (= (boat t) cannibal) 1 0)
    (ite (= (boat t) missionary) 1 0)
    (ite (and (= (boat t) 0) (= (direction t) 0)) 1 0)
	)1)
)

;The people left on the coast should be in majority missionaries
(define-fun CoastCapacity((coast Int)) Bool
	(= (+
    (ite (= coast (+ (* 1 missionary) (* 1 cannibal))) 1 0)
    (ite (= coast (+ (* 2 missionary) (* 1 cannibal))) 1 0)
    (ite (= coast (+ (* 3 missionary) (* 1 cannibal))) 1 0)
    (ite (= coast (+ (* 3 missionary) (* 2 cannibal))) 1 0)
    (ite (= coast (+ (* 2 missionary) (* 2 cannibal))) 1 0)
    (ite (= coast (+ (* 3 missionary) (* 3 cannibal))) 1 0)
    (ite (= coast (* 1 missionary) ) 1 0)
    (ite (= coast (* 2 missionary) ) 1 0)
    (ite (= coast (* 3 missionary) ) 1 0)
    (ite (= coast (* 1 cannibal) ) 1 0)
    (ite (= coast (* 2 cannibal) ) 1 0)
    (ite (= coast (* 3 cannibal) ) 1 0)
    (ite (= coast 0) 1 0)
	)1)
)

(define-fun BoatTurns((t Int)) Bool
(= (+
	(ite (and 
    (= (direction t) 0) (= (direction (- t 1)) 1) (= (direction (+ t 1)) -1) 
    (= (coastB t) (+ (coastB (- t 1)) (boat (- t 1))) )) 1 0)

  (ite (and 
    (= (direction t) 0) (= (direction (- t 1)) -1) (= (direction (+ t 1)) 1) 
    (= (coastA t) (+ (coastA (- t 1)) (boat (- t 1))) )) 1 0)

  (ite (and 
    (= (direction t) 1) (= (direction (+ t 1)) 0) 
    (= (coastA t) (- (coastA (- t 1)) (boat t)) )) 1 0)
        
  (ite (and 
    (= (direction t) -1) (= (direction (+ t 1)) 0) 
    (= (coastB t) (- (coastB (- t 1)) (boat t)) )) 1 0)   
	)1)
)

(assert (and
(= missionary 1)
(= cannibal 1000)

;define the first step
(= (coastA 0) (+ (* 3 cannibal) (* 3 missionary)))
(= (coastB 0) 0)
(= (boat 0) 0)
(= (direction 0) 0)

;define the first direction of the boat
(= (direction 1) 1)

;define the last step
(= (coastB N) (+ (* 3 cannibal) (* 3 missionary)))



;total value of all missionaries and all cannibals on the two coasts and boat remains the same
(forall ((t Int))
	(implies (<= 0 t N)
		(= (Total t)(Total (+ t 1)))
	)
)

(forall ((t Int))
	(implies (<= 1 t N)
    (and  
      (BoatTurns t) (BoatCapacity t) 
      (CoastCapacity (coastA t)) (CoastCapacity (coastB t))
    )
	)
)

;restrict the search to at most 20 steps
(<= 1 N 25)
))


(check-sat)
(get-value (
   N
  (coastA 0) (coastA 1) (coastA 2) (coastA 3) (coastA 4) (coastA 5) 
  (coastA 6) (coastA 7) (coastA 8) (coastA 9) (coastA 10) (coastA 11) 
  (coastA 12) (coastA 13) (coastA 14) (coastA 15) (coastA 16) (coastA 17) 
  (coastA 18) (coastA 19) (coastA 20) (coastA 21)  (coastA 22) (coastA 23)  
  (coastB 0) (coastB 1) (coastB 2) (coastB 3) (coastB 4) (coastB 5) 
  (coastB 6) (coastB 7) (coastB 8) (coastB 9) (coastB 10) (coastB 11) 
  (coastB 12) (coastB 13) (coastB 14) (coastB 15) (coastB 16) (coastB 17) 
  (coastB 18) (coastB 19) (coastB 20) (coastB 21)  (coastB 22) (coastB 23) 
  (boat 0) (boat 1) (boat 2) (boat 3) (boat 4) (boat 5) (boat 6) (boat 7) 
  (boat 8) (boat 9) (boat 10) (boat 11) (boat 12) (boat 13) (boat 14) 
  (boat 15) (boat 16) (boat 17) (boat 18) (boat 19) (boat 20) (boat 21)  
  (boat 22) (boat 23) 
  (direction 0) (direction 1) (direction 2) (direction 3) (direction 4) 
  (direction 5) (direction 6) (direction 7) (direction 8) (direction 9) 
  (direction 10) (direction 11) (direction 12) (direction 13) (direction 14) 
  (direction 15) (direction 16) (direction 17) (direction 18) (direction 19) 
  (direction 20) (direction 21)  (direction 22) (direction 23) 

))

