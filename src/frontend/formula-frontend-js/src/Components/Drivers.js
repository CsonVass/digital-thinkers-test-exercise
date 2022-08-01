import React from 'react';
import DriverCard from './DriverCard';
import {Container, Row} from 'react-bootstrap'


class Drivers extends React.Component {

    constructor(props){
        super(props);
        this.state = {cards: props.drivers}
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