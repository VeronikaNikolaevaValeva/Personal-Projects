(declare-fun B (Int Int) Int)
(declare-fun Hint (Int Int) Int)

(define-fun ColumnsOfSkyscrapers ((col Int)) Bool
	(distinct (B 1 col) (B 2 col) (B 3 col) (B 4 col) ) 
)

(define-fun Exactly4Columns () Bool
	(and (ColumnsOfSkyscrapers 1)
		 (ColumnsOfSkyscrapers 2)
		 (ColumnsOfSkyscrapers 3)
		 (ColumnsOfSkyscrapers 4)
	)
)

(define-fun RowsOfSkyscrapers ((row Int)) Bool
	(distinct (B row 1) (B row 2) (B row 3) (B row 4) ) 
)

(define-fun Exactly4Rows () Bool
	(and (RowsOfSkyscrapers 1)
		 (RowsOfSkyscrapers 2)
		 (RowsOfSkyscrapers 3)
		 (RowsOfSkyscrapers 4)
	)
)

(define-fun MinAndMaxValue ((row Int) (col Int)) Bool
	(and (<= 1 (B row col) 4))
)

(define-fun MinMaxOnRowAndCol ((col Int)) Bool
	(and (MinAndMaxValue 1 col)
		 (MinAndMaxValue 2 col)
		 (MinAndMaxValue 3 col)
		 (MinAndMaxValue 4 col)
	)
)

(define-fun MinMaxOnCol () Bool
	(and (MinMaxOnRowAndCol 1)
		 (MinMaxOnRowAndCol 2)
		 (MinMaxOnRowAndCol 3)
		 (MinMaxOnRowAndCol 4)
	)
)


(assert (and
		(= (Hint 1 5) (Hint 5 2) (Hint 5 4) 3)
))


(define-fun FindSkyscraperValueOnEachRow ((row Int)) Bool
	(and (=  (+ 1
			(ite (> (B row 2) (B row 1)) 1 0)
			(ite (and (> (B row 3) (B row 1)) (> (B row 3) (B row 2))) 1 0)
			(ite (and (> (B row 4) (B row 1)) (> (B row 4) (B row 2)) (> (B row 4) (B row 3)) ) 1 0)
			) (Hint row 0))

		(=  (+ 1
			(ite (> (B row 3) (B row 4)) 1 0)
			(ite (and (> (B row 2) (B row 3)) (> (B row 2) (B row 4))) 1 0)
			(ite (and (> (B row 1) (B row 2)) (> (B row 1) (B row 3)) (> (B row 1) (B row 4)) ) 1 0)
			) (Hint row 5))
))

(define-fun FindSkyscraperValuesForAllRows () Bool
	(and (FindSkyscraperValueOnEachRow 1 )
		 (FindSkyscraperValueOnEachRow 2 )
		 (FindSkyscraperValueOnEachRow 3 )
		 (FindSkyscraperValueOnEachRow 4 )
	)
)

(define-fun FindSkyscraperValueOnEachCol ((col Int)) Bool
	(and (=  (+ 1
			(ite (> (B 2 col) (B 1 col)) 1 0)
			(ite (and (> (B 3 col) (B 1 col)) (> (B 3 col) (B 2 col))) 1 0)
			(ite (and (> (B 4 col) (B 1 col)) (> (B 4 col) (B 2 col)) (> (B 4 col) (B 3 col)) ) 1 0)
			) (Hint 0 col))

		(=  (+ 1
			(ite (> (B 3 col) (B 4 col)) 1 0)
			(ite (and (> (B 2 col) (B 4 col)) (> (B 2 col) (B 3 col)) ) 1 0)
			(ite (and (> (B 1 col) (B 4 col)) (> (B 1 col) (B 3 col)) (> (B 1 col) (B 2 col)) ) 1 0)
			) (Hint 5 col))
))

(define-fun FindSkyscraperValuesForAllCols () Bool
	(and (FindSkyscraperValueOnEachCol 1 )
		 (FindSkyscraperValueOnEachCol 2 )
		 (FindSkyscraperValueOnEachCol 3 )
		 (FindSkyscraperValueOnEachCol 4 )
	)
)


(assert (and
			 MinMaxOnCol Exactly4Columns Exactly4Rows 
			FindSkyscraperValuesForAllRows FindSkyscraperValuesForAllCols
		)
)

		
(check-sat)
(get-model)
(get-value (
	(B 1 1) (B 1 2) (B 1 3) (B 1 4) 
	(B 2 1) (B 2 2) (B 2 3) (B 2 4) 
	(B 3 1) (B 3 2) (B 3 3) (B 3 4) 
	(B 4 1) (B 4 2) (B 4 3) (B 4 4) 

))

