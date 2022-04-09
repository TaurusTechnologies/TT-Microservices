import * as React from 'react';
import { connect } from 'react-redux';

const Home = () => (
  <div>
    <h1>Temporary Landing Page</h1>
    <p>Eventually this will be a replacement for the original DB as more services come in</p>
  </div>
);

export default connect()(Home);