import React, { Component } from 'react';

import { Text, View, StyleSheet } from 'react-native';

class CadastrarProjeto extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Cadastrar Projeto</Text>
            </View>
        )
    }
}

export default CadastrarProjeto;

const styles = StyleSheet.create ({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#CCCCCC',
      }
});    