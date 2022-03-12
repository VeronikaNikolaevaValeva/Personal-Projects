; Zebra puzzle
(declare-const pink Int)
(declare-const yellow Int)
(declare-const red Int)
(declare-const fish Int)
(declare-const mouse Int)
(declare-const zebra Int)
(declare-const tea Int)
(declare-const coffee Int)
(declare-const beer Int)
(declare-fun Colour (Int) Int)
(declare-fun Animal (Int) Int)
(declare-fun Drink (Int) Int)


(define-fun ColourOfTheHouse((t Int)) Bool
	(=(+
    (ite (and (= (Colour t) pink) (= (Animal t) fish) ) 1 0)
    (ite (= (Colour t) yellow) 1 0)
    (ite (and (= (Colour t) red) (not(= t 3)) ) 1 0)
  )1)
)

(define-fun AnimalOfTheHouse((t Int)) Bool
	(=(+
    (ite (and (= (Animal t) fish) (= (Colour t) pink) ) 1 0)
    (ite (= (Animal t) mouse) 1 0)
    (ite (= (Animal t) zebra) 1 0)
  )1)
)

(define-fun DrinkOfTheHouse((t Int)) Bool
	(=(+
    (ite (= (Drink t) tea) 1 0)
    (ite (= (Drink t) coffee) 1 0)
    (ite (= (Drink t) beer) 1 0)
  )1)
)

(define-fun TeaLivingToTheLeftOfTHePink() Bool
	(=(+
    (ite (and (= (Colour 2) pink) (= (Drink 1) tea) ) 1 0)
    (ite (and (= (Colour 3) pink) (= (Drink 2) tea) ) 1 0)
  )1)
)

(define-fun ZebraLivingTOTheLeftOfTheFish() Bool
	(=(+
    (ite (and (= (Animal 2) fish) (= (Animal 1) zebra) ) 1 0)
    (ite (and (= (Animal 3) fish) (= (Animal 2) zebra) ) 1 0)
  )1)
)

(assert (and
(= pink 100) (= yellow 200) (= red 300)
(= fish 10) (= mouse 20) (= zebra 30)
(= tea 1) (= coffee 2) (= beer 3)

(forall ((t Int))
  (implies 
    (<= 1 t 3)
    (and
      (ColourOfTheHouse t) (AnimalOfTheHouse t) (DrinkOfTheHouse t) 
      TeaLivingToTheLeftOfTHePink ZebraLivingTOTheLeftOfTheFish
      (= (Drink 2) beer)
    )
  )
)

))


(check-sat)
(get-value (
  (Colour 1) (Colour 2) (Colour 3)
  (Animal 1) (Animal 2) (Animal 3)
  (Drink 1) (Drink 2) (Drink 3)
))

