# CatEscape

1. Link to tutorial.  
https://www.amazon.co.jp/Unity5%E3%81%AE%E6%95%99%E7%A7%91%E6%9B%B8-2D%EF%BC%863D%E3%82%B9%E3%83%9E%E3%83%BC%E3%83%88%E3%83%95%E3%82%A9%E3%83%B3%E3%82%B2%E3%83%BC%E3%83%A0%E5%85%A5%E9%96%80%E8%AC%9B%E5%BA%A7-%E5%8C%97%E6%9D%91-%E6%84%9B%E5%AE%9F-ebook/dp/B01H4ONR86?language=en_US  

2. Why You picked this tutorial?  
My friend reccomended this. He told me this is most understandable book for unity bigginers.  

3. What was hard part?  
understanding collision detection part, mathematical things in ArrowController.cs  

	// collision detection

	Vector2 p1 = transform.position;  
        Vector2 p2 = this.player.transform.position;  
        Vector2 dir = p1 - p2;  
        float d = dir.magnitude;  
        float r1 = 0.5f;  
        float r2 = 1.0f;  

        if(d < r1 + r2)
        {
            Destroy(gameObject);

            // tell Director collision to Player
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }


4. What did you learn from it?  
how to cast Objecty type to GameObject type in ArrowGenerator.cs  

 	// Update is called once per frame

	void Update () {

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            
            // This part
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }


5. What new did you added to game? (bonus)  
N/A
