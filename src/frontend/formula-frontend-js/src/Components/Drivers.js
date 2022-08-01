import React from 'react';
import DriverCard from './DriverCard';
import {Container, Row} from 'react-bootstrap';
import {overTake} from '../Services/api';


class Drivers extends React.Component {

    constructor(props){
        super(props);
        this.state = {cards: props.drivers}
    }

    overTakeDriver(id){
        overTake(id).then(data => {         
            let newCards = this.state.cards;
            newCards.find(d => d["id"] === data[0]["id"])["place"] = data[0]["place"]
            newCards.find(d => d["id"] === data[1]["id"])["place"] = data[1]["place"]
            this.setState({cards: newCards})

            console.log(`${data[0]["lastname"]} new place ${data[0]["place"]}`)
            console.log(`${data[1]["lastname"]} new place ${data[1]["place"]}`)
        })
    }
   
  render(){   

    let driverCards = []

    this.state.cards.forEach(card_ => {
        driverCards.push(
            <DriverCard
                key={card_["id"]}
                name={card_["firstname"]+card_["lastname"]}
                team={card_["team"]}
                currentPlace={card_["place"]}
                code={card_["code"]}
                country={card_["country"]}

                onClick={() => this.overTakeDriver(card_["id"])}
            />
        )
    });

    driverCards = driverCards.sort((a,b) => a.props["currentPlace"] - b.props["currentPlace"])


    
  return (
    <Container className='table table-striped'>
        <Row>
        {driverCards}
        </Row>
    </Container>

  )
    }
}

export default Drivers