import * as React from 'react';
import { connect } from 'react-redux';

const Project = () => (
  <div>
    <h1>Hello, Project!</h1>
  </div>
);

export default connect()(Project);
