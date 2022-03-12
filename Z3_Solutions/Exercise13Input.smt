(declare-const dog Int)
(declare-const cat Int)
(declare-const mice Int)
(declare-const budget Int)
(declare-fun Step (Int) Int)
(declare-fun AnimalBought (Int) Int)
(declare-const N Int)

;On every step an animal is bought.
;Add the sum of the animal to the step
;Save the cost of the added animal on each step
(define-fun BuyAnAnimal((t Int)) Bool
	(=(+
    (ite (and (= (Step t) (+ (Step (- t 1)) dog)) (= (AnimalBought t) dog)) 1 0)
    (ite (and (= (Step t) (+ (Step (- t 1)) cat)) (= (AnimalBought t) cat)) 1 0)
    (ite (and (= (Step t) (+ (Step (- t 1)) mice)) (= (AnimalBought t) mice)) 1 0)
  )1)
)


;Set the values for the animals and the budget
;The begin state is 0 and the final step should be equal to the budget
;On every step and animal is bought
;Forall steps there exist at least one purchase of every animal
(assert (and
  (= dog 60)
  (= cat 4)
  (= mice 1)
  (= budget 400)
  (= (Step 0) 0)
  (= (Step N) budget)
  (= (AnimalBought 0) 0)

  (forall ((t Int))
    (implies 
      (<= 1 t N)
      (and
        (BuyAnAnimal t)
        (exists ((t Int))
          (= (AnimalBought t) dog)
        )
        (exists ((t Int))
          (= (AnimalBought t) cat)
        )
        (exists ((t Int))
          (= (AnimalBought t) mice)
        )
      )
    )
  )

; restrict the search to at most 10 steps
  (<= 1 N 30)
))


(check-sat)
(get-value (
  N
   (Step 0) (Step 1) (Step 2) (Step 3) (Step 4) (Step 5)
   (Step 6) (Step 7) (Step 8) (Step 9) (Step 10) (Step 11)
   (Step 12) (Step 13) (Step 14) (Step 15) (Step 16) 
   (Step 17) (Step 18) (Step 19) (Step 20) (Step 21) (Step 22)
   (AnimalBought 0) (AnimalBought 1) (AnimalBought 2) (AnimalBought 3) (AnimalBought 4) (AnimalBought 5)
   (AnimalBought 6) (AnimalBought 7) (AnimalBought 8) (AnimalBought 9) (AnimalBought 10) (AnimalBought 11)
   (AnimalBought 12) (AnimalBought 13) (AnimalBought 14) (AnimalBought 15) (AnimalBought 16) 
   (AnimalBought 17) (AnimalBought 18) (AnimalBought 19) (AnimalBought 20) (AnimalBought 21) (AnimalBought 22)
))

