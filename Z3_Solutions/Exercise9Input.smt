(declare-const row1 Int)
(declare-const col1 Int)
(declare-const length1 Int)
(declare-const quadrant1 Int)

(declare-const row2 Int)
(declare-const col2 Int)
(declare-const length2 Int)
(declare-const quadrant2 Int)

(declare-const row3 Int)
(declare-const col3 Int)
(declare-const length3 Int)
(declare-const quadrant3 Int)

(define-fun DefineTriangleStartingPointAndDirection ((row Int) (col Int) (length Int) (quadrant Int)) Bool  
    (= (+
          (ite (and
                (= quadrant 1) (<= (+ col length) 5)  (<= (+ row length) 5) ) 1 0)
          (ite (and 
                (= quadrant 2) (>= (- col length) 1) (<= (+ row length) 5) ) 1 0)
          (ite (and 
                (= quadrant 3) (<= (+ col length) 5) (>= (- row length) 1) ) 1 0)
          (ite (and 
                (= quadrant 4) (>= (- col length) 1) (>= (- row length) 1) ) 1 0) 
    )1)
)

(assert(and
	  (forall ((row Int) (col Int) (length Int) (quadrant Int))
      (and
        (exists ((row Int) (col Int) (length Int) (quadrant Int))  
			    (and 
              (<= 1 row 5) (<= 1 col 5) (<= 2 length 4) (<= 1 quadrant 4) 
			        (DefineTriangleStartingPointAndDirection row col length quadrant)
              (= row1 row) (= col1 col) (= length1 length) (= quadrant1 quadrant)
          ) 
        )
        (exists ((row Int) (col Int) (length Int) (quadrant Int))  
			    (and 
              (<= 1 row 5) (<= 1 col 5) (<= 2 length 4) (<= 1 quadrant 4) 
			        (DefineTriangleStartingPointAndDirection row col length quadrant)
              (= row2 row) (= col2 col) (= length2 length) (= quadrant2 quadrant)
          ) 
        )
        (exists ((row Int) (col Int) (length Int) (quadrant Int))  
			    (and 
              (<= 1 row 5) (<= 1 col 5) (<= 2 length 4) (<= 1 quadrant 4) 
			        (DefineTriangleStartingPointAndDirection row col length quadrant)
              (= row3 row) (= col3 col) (= length3 length) (= quadrant3 quadrant)
          ) 
        )
      ) 
		)
	)
)

(define-fun DeclareThatTheCellIsInTheGivenTriangle ((gridRow Int) (gridCol Int) (row Int) (col Int) (length Int) (quadrant Int)) Bool  
    (> (+
          (ite (and (= quadrant 1) (or  
          (and (<= col gridCol (+ col length)) (= gridRow row)) 
          (and (<= row gridRow (+ row length)) (= gridCol col))
          (= (+ (- gridRow row) (- gridCol col)) length) )) 1 0)
          
          (ite (and (= quadrant 2) (or  
          (and (<= (- col length) gridCol col) (= gridRow row)) 
          (and (<= row gridRow (+ row length)) (= gridCol col))
          (= (+ (- gridRow row) (- col gridCol)) length) )) 1 0)
          
          (ite (and (= quadrant 3) (or  
          (and (<= col gridCol (+ col length)) (= gridRow row)) 
          (and (<= (- row length) gridRow row) (= gridCol col))
          (= (+ (- row gridRow) (- col gridCol)) length) )) 1 0)
          
          (ite (and (= quadrant 4) (or  
          (and (<= (- col length) gridCol col)(= gridRow row)) 
          (and (<= (- row length) gridRow row)(= gridCol col))
          (= (+ (- row gridRow) (- gridCol col)) length) )) 1 0)
    )0)
)

(assert(and
  (forall ( (row Int) (col Int) )
    (implies
      (and (<= 1 row 5) (<= 1 col 5))
      (> (+ 
      
        (ite (DeclareThatTheCellIsInTheGivenTriangle row col row1 col1 length1 quadrant1) 1 0)

        (ite (DeclareThatTheCellIsInTheGivenTriangle row col row2 col2 length2 quadrant2) 1 0)

        (ite (DeclareThatTheCellIsInTheGivenTriangle row col row3 col3 length3 quadrant3) 1 0)

      )0)
    )
  )
))


(check-sat)
(get-value (
  row1 col1 length1 quadrant1
  row2 col2 length2 quadrant2
  row3 col3 length3 quadrant3
))
